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

using namespace std;
using namespace cv;

struct EuclideanDistanceFunctor
{
    int _dist2;
    EuclideanDistanceFunctor(int dist) : _dist2(dist*dist) {}

    bool operator()(const Point& lhs, const Point& rhs) const
    {
        return ((lhs.x - rhs.x)*(lhs.x - rhs.x) + (lhs.y - rhs.y)*(lhs.y - rhs.y)) < _dist2;
    }
};

int main( int argc, const char** argv )
{

	try{
		string filePath = argv[1];
		cout << filePath << endl;
		VideoCapture cap(filePath); // open the video file for reading
	// VideoCapture cap("C:/Users/Angelo/Documents/MATLAB/PianoRollVid.avi"); // open the video file for reading
	   cap.set(CV_CAP_PROP_POS_MSEC, 0); //start the video at 300ms
	   double numFrames = cap.get(CV_CAP_PROP_FRAME_COUNT);
    double fps = cap.get(CV_CAP_PROP_FPS); //get the frames per seconds of the video

     //cout << "Frame per seconds : " << fps << endl;
	 //cout << "Number of frames : " << numFrames << endl;
    namedWindow("MyVideo",CV_WINDOW_AUTOSIZE); //create a window called "MyVideo"
	//Define coordinates for box to look for pixels
	int subFrameXCoord = 45; 
	int subFrameYCoord = 300; 
	int subFrameWidth = 1014; 
	int subFrameHeight = 13;
	// Define the distance between clusters
    int euclidean_distance = 4;
	ofstream noteFile("temporaryOutputFileForReading.txt");
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

        imshow("MyVideo", frame); //show the frame in "MyVideo" window
		Mat edge,draw,subFrame;//,noZeroCoords;
		vector<Point> noZeroCoords;
		
		subFrame = frame(Rect(subFrameXCoord,subFrameYCoord,subFrameWidth,subFrameHeight)); //best range for this video 

		Canny(subFrame,edge,50,150,3);
		int countNon0 = countNonZero(edge);
		if(countNon0 == 0){
			//Output empty array
			//cout << "fail" << endl;
			for(int i = 0; i < 88; i++){
				noteFile << outputNoteVec[i] << " ";
			}
		}
		else{
			findNonZero(edge,noZeroCoords);
		vector<int> labels;

    // With functor
    int n_labels = partition(noZeroCoords, labels, EuclideanDistanceFunctor(euclidean_distance));

    // With lambda function
    //int th2 = euclidean_distance * euclidean_distance;
    //int n_labels = partition(noZeroCoords, labels, [th2](const Point& lhs, const Point& rhs) {
    //    return ((lhs.x - rhs.x)*(lhs.x - rhs.x) + (lhs.y - rhs.y)*(lhs.y - rhs.y)) < th2;
  //  });


    // Store all points in same cluster, and compute centroids
    vector<vector<Point>> clusters(n_labels);
    vector<Point> centroids(n_labels, Point(0,0));

    for (int i = 0; i < noZeroCoords.size(); ++i)
    {
        clusters[labels[i]].push_back(noZeroCoords[i]);
        centroids[labels[i]] += noZeroCoords[i];
    }
    for (int i = 0; i < n_labels; ++i)
    {
        centroids[i].x /= clusters[i].size();
		//cout << centroids[i].x + subFrameXCoord << endl;
        centroids[i].y /= clusters[i].size();
    }

	//Loop through centroids and see where they fall
	int vectCtr = 0;
	for (int i = 0; i < 84; ++i)
    {
		//I think vectCtr is getting too big
		if(vectCtr < n_labels){
			if((centroids[vectCtr].x + subFrameXCoord < 12*(i+1)) && (centroids[vectCtr].x + subFrameXCoord > 12*i)){
				vectCtr++;
				outputNoteVec[i] = 1;
			}
			else
				outputNoteVec[i] = 0;
        
		}
	}
    // Draw results

    // Build a vector of random color, one for each class (label)
    vector<Vec3b> colors;
    for (int i = 0; i < n_labels; ++i)
    {
        colors.push_back(Vec3b(rand() & 255, rand() & 255, rand() & 255));
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
	for(int i = 0; i < 88; i++){
		noteFile << outputNoteVec[i] << " ";
		}
	noteFile << endl;
	if(waitKey(30) == 27) //wait for 'esc' key press for 30 ms. If 'esc' key is pressed, break loop
       {
                //cout << "esc key is pressed by user" << endl; 
                break; 
       }
		
	}/*
		cout << tempMin << " " << pixCountCurrRange << endl;
		edge.convertTo(draw, CV_8U);

		 namedWindow("image", CV_WINDOW_AUTOSIZE);
		 imshow("image", draw);
		 fill(outputNoteVec.begin(),outputNoteVec.end(),0);
    }
	*/
		}
    return 0;
	}

	catch(Exception & e){
		cerr << e.msg << endl;
	}
}
