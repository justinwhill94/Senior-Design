README for Scroll Reader Computer Vision Code:
==============================================

Purpose:
	The purpose of the computer vision code in this project is to calculate the pixel locations of 
	the notes on a piano scroll.

Description:
	This was implemented in C++, using visual studio for general development and the OpenCV library 
to develop the computer vision algorithms. In order to calculate the pixel locations of the notes, the following steps
had to be followed for every single frame in the video file (Note that the minimum required frame rate for this product is
30 frames per second).

1. Determine the region of interest to search for notes in the current frame (currently, this is hard-coded, but in future
releases the user either will select the region or it will be determined automatically). The region of interest is used to
determine the range of pixel values where a certain note might fall. For example, if the width of the region of interest is
1000 pixels, and there are 88 notes that we are searching for, there is a range of 11.363 pixels for each note to fall within.

2. Perform Canny edge detection on the region of interest to obtain a set of pixels containing the pixel locations of the edges
of all of the notes.

3. Perform a clustering algorithm on the set of edge pixels in order to obtain the centroids of each note.

4. Use the centroid x position in order to determine which note(s) to play for a current frame.

5. Output results
