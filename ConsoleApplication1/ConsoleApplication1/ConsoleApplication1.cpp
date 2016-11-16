// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "opencv2/core/core.hpp"
#include "opencv2/flann/miniflann.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/photo/photo.hpp"
#include "opencv2/video/video.hpp"
#include "opencv2/features2d/features2d.hpp"
#include "opencv2/objdetect/objdetect.hpp"
#include "opencv2/calib3d/calib3d.hpp"
#include "opencv2/ml/ml.hpp"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/contrib/contrib.hpp"
#include "opencv2/core/core_c.h"
#include "opencv2/highgui/highgui_c.h"
#include "opencv2/imgproc/imgproc_c.h"
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <math.h>

using namespace std;
using namespace cv;

// Struct used in calculation of euclidean distance (used in clustering algorithm)
struct EuclideanDistanceFunctor
{
    int _dist2;
    EuclideanDistanceFunctor(int dist) : _dist2(dist*dist) {}

    bool operator()(const Point& lhs, const Point& rhs) const
    {
        return ((lhs.x - rhs.x)*(lhs.x - rhs.x) + (lhs.y - rhs.y)*(lhs.y - rhs.y)) < _dist2; //Equation for euclidean distance
    }
};

int main( int argc, const char** argv )
{

	try{
		//Used in debugging to play video 
		bool playVideo = true;

		//get file name (for use in GUI)
		string filePath = argv[1];
		cout << filePath << endl;
		VideoCapture cap(filePath); // open the video file for reading
		cap.set(CV_CAP_PROP_POS_MSEC, 300); //start the video at 300ms
		double numFrames = cap.get(CV_CAP_PROP_FRAME_COUNT);
		double fps = cap.get(CV_CAP_PROP_FPS); //get the frames per seconds of the video

     //cout << "Frame per seconds : " << fps << endl;
	 //cout << "Number of frames : " << numFrames << endl;
	if (playVideo){
		namedWindow("PianoScrollVideo",CV_WINDOW_AUTOSIZE); //create a window 
	}
	//Define coordinates for box to look for pixels
	//Improvement: user enters boundaries of ROI or it is automatically detected
	int subFrameXCoord = 45; 
	int subFrameYCoord = 300; 
	int subFrameWidth = 1014; 
	int subFrameHeight = 8;

	//How far apart each note is
	double individualNoteRes = subFrameWidth/84.0;

	// Define the distance between clusters
    int euclidean_distance = 6;
	//File where output vector is sent
	ofstream noteFile("temporaryOutputFileForReading.txt");

	//Run through video
    while(1)
    {
        Mat frame;
		vector<int> outputNoteVec(88);

        bool bSuccess = cap.read(frame); // read a new frame from video

         if (!bSuccess) //if not success, break loop
        {
            //cout << "Cannot read the frame from video file" << endl;
            break;
        }

		if (playVideo){
			imshow("PianoScrollVideo", frame); //show the frame in "MyVideo" window
		}
		Mat edge,draw,subFrame;//,noZeroCoords;
		vector<Point> noZeroCoords;
		
		//Set the region of interest (ROI) to search for edges
		subFrame = frame(Rect(subFrameXCoord,subFrameYCoord,subFrameWidth,subFrameHeight));  

		//Detect edges
		Canny(subFrame,edge,50,150,3);
		int countNon0 = countNonZero(edge);

		//Check to see if any edges were found
		if(countNon0 == 0){
			//If none...
			//Output array or zeros
			for(int i = 0; i < 88; i++){
				noteFile << outputNoteVec[i] << " ";
			}
			noteFile << endl;
		}
		else{
			//Find pixel locations of all edges
			findNonZero(edge,noZeroCoords);

			vector<int> labels;

			//Calculate the number of clusters
			int n_labels = partition(noZeroCoords, labels, EuclideanDistanceFunctor(euclidean_distance));

			// Store all points in same cluster, and compute centroids
			vector<vector<Point>> clusters(n_labels);
			//Initialize the vector of centroids
			vector<Point> centroids(n_labels, Point(0,0));

			//Add the pixel locations of the edges to the set of clusters and centroids
			for (int i = 0; i < noZeroCoords.size(); ++i)
			{
				clusters[labels[i]].push_back(noZeroCoords[i]);
				centroids[labels[i]] += noZeroCoords[i];
			}
			//Calculate the x and y positions of all the centroids
			for (int i = 0; i < n_labels; ++i)
			{
				centroids[i].x /= clusters[i].size();
				centroids[i].y /= clusters[i].size();
			}

			//Initialize the counter that is used to loop through the centroids
			int vectCtr = 0;
				if(playVideo){
				for(int j = 0; j < n_labels; j++){
					cout << centroids[j].x << " ";
				}
				cout << endl;
			}

			//int i = 0;
			while(vectCtr < n_labels){
			//for (int i = 0; i < 84; ++i){
				if(vectCtr <= n_labels){
					//The note location on the piano is the rounded result of the x location of each centroid divided by the range of pixels for any note
					int noteLoc = floor((centroids[vectCtr].x)/individualNoteRes +.5)+1;
					outputNoteVec[noteLoc] = 1;
					vectCtr++;
					//There is a ~11.5 pixel zone in which each note might fall, so check to see if the x coordinate of the current cluster lies within this zone
					/*if((centroids[vectCtr].x <= 1.05*individualNoteRes*(i+1)) && (centroids[vectCtr].x >= .95*individualNoteRes*i)){
						//cout << centroids[vectCtr].x + subFrameXCoord << " ";
						vectCtr++;
						outputNoteVec[i] = 1;
					}
					else
						outputNoteVec[i] = 0;*/
				}
				//Mod the value of i in order to guarantee that all elements of centroids are checked
				//i = (i+1)%84;
			}

			//Only draw results if the debugging option for playing the video is enabled
			if (playVideo){
			// Draw results
			// Build a vector of random color, one for each class (label)
			vector<Vec3b> colors;
			for (int i = 0; i < n_labels; ++i)
			{
				colors.push_back(Vec3b(0 & 255, 255 & 255, 0 & 255));
			}

			// Draw the points
			Mat3b res(frame.rows, frame.cols, Vec3b(0, 0, 0));
			for (int i = 0; i < noZeroCoords.size(); ++i)
			{
				res(noZeroCoords[i]) = colors[labels[i]];
			}

			// Draw centroids
			for (int i = 0; i < n_labels; ++i)
			{
				circle(res, centroids[i], 3, Scalar(colors[i][0], colors[i][1], colors[i][2]), CV_FILLED);
				circle(res, centroids[i], 6, Scalar(255 - colors[i][0], 255 - colors[i][1], 255 - colors[i][2]));
			}

			
				imshow("Clusters", res);
			}
			for(int i = 0; i < 88; i++){
				noteFile << outputNoteVec[i] << " ";
			}
			noteFile << endl;
	
			if(waitKey(30) == 27) //wait for 'esc' key press for 30 ms. If 'esc' key is pressed, break loop
			   {
					//cout << "esc key is pressed by user" << endl; 
					break; 
			   }
			if (playVideo){
				for(int i = 0; i < 88; i++){
					cout << outputNoteVec[i] << " ";
				}
				cout << endl;
				waitKey();
			}
		}
	}
    return 0;
	}

	catch(Exception & e){
		//cerr << e.msg << endl;
	}
}
