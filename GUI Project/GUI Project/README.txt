README for Scroll Reader User Interface
================================================================
Purpose:
	The purpose of the Scroll Reader user interface is to allow the user to easily and intuitively use 
	the functionality of the Scroll Reader application. This is accomplished through a simple and intuitive 
	user interface that guides the user on how to use the application.

Description:
	The primary features of the Scroll Reader user interface are the file/folder selection and 
audio/video playback dialogs. The file selection dialog allows the user to select one or more video files 
(in the .avi file format) that the scroll reader application will then attempt to generate a midi audio file 
corresponding to the notes detected in the video. The application assumes that the provided video file is 
of a player piano scroll being turned at a rate appropriate for the song. Once the user has selected their 
video file(s), they can select the directory that their audio (.midi) equivalent files will be stored in. The 
application will automatically generate a name for the files based on the name of the input video file. 
Next the user can select their preferences on the main screen, which will determine the behavior of the 
audio/video playback dialog form when the user selects “Run”. Once the user has pressed “Run”, the 
application will begin the computer vision processing, displaying some information on the processing in 
a prompt-like window. Once the computer vision processing is complete (15-60 seconds depending on 
the machine) the user interface switches to the audio and video playback dialog form. Based on the 
user’s choices the form may have the video with the original audio (only Video playback selected), the 
video with the newly generated audio (Video and Audio playback selected), or no video with the newly 
generated audio (only Audio playback selected). The user is able to play/pause the video at any time. 
Once the user has exited from the playback form, the application exits. 

See the user manual in the Measured Solutions GitHub repository for additional details.
