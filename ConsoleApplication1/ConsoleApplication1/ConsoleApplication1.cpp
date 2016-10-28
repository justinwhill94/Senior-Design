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

using namespace std;
using namespace cv;

int main( int argc, const char** argv )
{
	try{
	 VideoCapture cap("C:/Users/Angelo/Documents/MATLAB/PianoRollVid.avi"); // open the video file for reading
	   //cap.set(CV_CAP_PROP_POS_MSEC, 300); //start the video at 300ms

    double fps = cap.get(CV_CAP_PROP_FPS); //get the frames per seconds of the video

     cout << "Frame per seconds : " << fps << endl;

    namedWindow("MyVideo",CV_WINDOW_AUTOSIZE); //create a window called "MyVideo"
	int subFrameXCoord = 45; 
	int subFrameYCoord = 300; 
	int subFrameWidth = 1014; 
	int subFrameHeight = 13;
    while(1)
    {
        Mat frame;
		vector<int> outputNoteVec(88);

        bool bSuccess = cap.read(frame); // read a new frame from video

         if (!bSuccess) //if not success, break loop
        {
                        cout << "Cannot read the frame from video file" << endl;
                       break;
        }

        imshow("MyVideo", frame); //show the frame in "MyVideo" window
		Mat edge,draw,subFrame,noZeroCoords;
		
		
		subFrame = frame(Rect(subFrameXCoord,subFrameYCoord,subFrameWidth,subFrameHeight)); //best range for this video 

		Canny(subFrame,edge,50,150,3);
		findNonZero(edge,noZeroCoords);
		int i = 0;
		int j = 0;
		int arrInd = 0;/*
		while(i < subFrameWidth){
			for(j = 0; j < 12; j++){

			}
			if((12*arrInd + subFrameXCoord)){

			}
			arrInd++;
		}*/
		int pixCountCurrRange = 0; //Pixel count for the nth note where n is arrInd
		int tempMin = 999;
		for (int i = 0; i < noZeroCoords.total(); i++ ) {
			cout << "Zero#" << i << ": " << noZeroCoords.at<Point>(i).x + subFrameXCoord << ", " << noZeroCoords.at<Point>(i).y + subFrameYCoord << endl;
			if(noZeroCoords.at<Point>(i).x < tempMin){
				tempMin = noZeroCoords.at<Point>(i).x;
				pixCountCurrRange = i;
			}
			/*if(((noZeroCoords.at<Point>(i).x + subFrameXCoord) >= 12*arrInd)&&((noZeroCoords.at<Point>(i).x + subFrameXCoord) <= 12*(arrInd+1))){
				pixCountCurrRange++;
			}
			if(pixCountCurrRange >= 3){
				outputNoteVec[arrInd] = 1;
				arrInd++;
				pixCountCurrRange = 0;

			}
		}
		//cout << noZeroCoords+45 << endl; //Need to figure out how to add vertical offset
		for(int i = 0; i < outputNoteVec.size(); i++){
			cout << outputNoteVec[i] << " ";*/
		}
		cout << tempMin << " " << pixCountCurrRange << endl;
		edge.convertTo(draw, CV_8U);
		
		
//		circle(frame,Point(noZeroCoords.at<Point>(1).x,noZeroCoords.at<Point>(1).y),2,Scalar(0));
		 namedWindow("image", CV_WINDOW_AUTOSIZE);
		 imshow("image", draw);
		 fill(outputNoteVec.begin(),outputNoteVec.end(),0);
        if(waitKey(30) == 27) //wait for 'esc' key press for 30 ms. If 'esc' key is pressed, break loop
       {
                cout << "esc key is pressed by user" << endl; 
                break; 
       }
    }

    return 0;
	}

	catch(Exception & e){
		cerr << e.msg << endl;
	}
}
