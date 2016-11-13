using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Media;

namespace GUI_Project
{
    
    
    public partial class MainGui : Form
    {

        //[DllImport("C:\\Users\\Matthew\\Desktop\\UK\\Fall 2016\\Senior-Design-GUI\\GUI Project\\GUI Project\\CV\\MidiConverter.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        //stringpublic static extern int ParseFile(string Fname, string Dname);

        static void LaunchCV(string file_path)
        {
            
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "..\\..\\CV\\ScrollReader_CV.exe";
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = "\"" + file_path + "\"";

                try
                {

                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {

                    // Log error.
                    MessageBox.Show("There was a problem with the MIDI generation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //Need to end conversion and display an error MessageBox
                }

        }

        static void LaunchMIDI(string notes_file, string dest_file)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "..\\..\\CV\\MidiConverter.exe";
            startInfo.CreateNoWindow = true;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "\"" + notes_file + "\"" + " " + "\"" + dest_file + "\"";
            try
            {

                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {

                // Log error.
                MessageBox.Show("There was a problem opening the file for conversion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //Need to end conversion and display an error MessageBox
            }
        }
        public MainGui()
        {
            
            InitializeComponent();
            MainUIPanel.Visible = true;

            CV_ProgressBar.MarqueeAnimationSpeed = 0;
        }

        //list of file paths, both source and destination
        List<string> SourceFileNames = new List<string>();
        List<string> DestinationFileNames = new List<string>();
        List<string> DestinationFilePaths = new List<string>();
        string DestFolderName;
        //bools for remembering if a source/dest file were chosen  
        bool OpenPressed = false;
        bool SavePressed = false;
        
        private void Search_Click(object sender, EventArgs e)
        {
            //open up a dialog for choosing which files to open
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            //right now we only have support for avi, once we have a definte list of acceptable 
            //file types, those can be added here
            OpenFile.Filter = "AVI Videos (*.avi) | *.avi"; 
            OpenFile.ShowDialog();
           
            //only do something if the user actually chose a file
            if (OpenFile.FileName != "")
            {
                //clear out any older files (just in case the user changed their mind and chose a different file)
                SourceFileNames.Clear();
                UserSourceFilePath.Text = "";
                SourceFileNames = new List<string>();
                //loop through each of the filenames the user chose and save them to the list of source files and generate
                //the corresponding destination file
                foreach(string file in OpenFile.FileNames)
                {
                    UserSourceFilePath.Text += file + ";";
                    //add the source file path to the list
                    SourceFileNames.Add(file);
                    //set the destination file path to the same name, but with the midi file extension
                    int begin = file.LastIndexOf('\\');
                    int end = file.LastIndexOf('.');
                    string dest_file = file.Substring(begin, end - begin + 1);
                    dest_file += "midi";
                    DestinationFileNames.Add(dest_file);
                }
                OpenPressed = true;
                

                
            }
           
        }

        private void DestOpenButton_Click(object sender, EventArgs e)
        {
            
            //Open up the folder dialog, so the user can select where their new files will be stored
            FolderBrowserDialog saveDestDlg = new FolderBrowserDialog();
            if(saveDestDlg.ShowDialog() == DialogResult.OK)
            {
                DestFolderName = saveDestDlg.SelectedPath;
                UserDestFilePath.Text = DestFolderName;
                SavePressed = true;
                
            }

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //Testmain(SourceFileNames[0]);
            if(!OpenPressed)
            {
                
                MessageBox.Show("Please enter a Source file path", "Error: No Source File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!SavePressed)
            {
                
                MessageBox.Show("Please enter a Destination file path", "Error: No Destination File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*CV_ProgressBar.Style = ProgressBarStyle.Marquee;
                BackgroundWorker CV_BackgroundWorker = new BackgroundWorker();
                CV_BackgroundWorker.DoWork += new DoWorkEventHandler(CV_BackgroundWorker_DoWork);
                CV_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CV_BackgroundWorker_RunWorkerCompleted);
                CV_ProgressBar.Visible = true;*/
                foreach(string dest_file in DestinationFileNames)
                {
                    string dest_path = DestFolderName  + dest_file;
                    DestinationFilePaths.Add(dest_path);

                }
                int index = 0;
                foreach(string file in SourceFileNames)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //Run the computer vision program
                    LaunchCV(file);
                    //Run the Midi generation program
                    LaunchMIDI(".\\temporaryOutputFileForReading.txt", DestinationFilePaths[index]);
                    Cursor.Current = Cursors.Arrow;

                    //increment the index so we know which DestinationFilePath to use
                    index++;
                }
                //CV_ProgressBar.MarqueeAnimationSpeed = 0;
                CV_ProgressBar.Hide();
                
            }
            //If the user wants video playback
            if(VideoPlaybackCheckBox.Checked)
            {
                //create the playback form and fill the primary media player's playlist with the piano scroll videos
                AudioVideoPlayback videoWindow = new AudioVideoPlayback(AudioPlaybackCheckBox.Checked, DestinationFilePaths);
                WMPLib.IWMPPlaylist playlist = videoWindow.axWindowsMediaPlayer1.playlistCollection.newPlaylist("PianoScrolls_Original");
                WMPLib.IWMPMedia media;
                foreach (string file in SourceFileNames)
                {
                    media = videoWindow.axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
                videoWindow.axWindowsMediaPlayer1.currentPlaylist = playlist;
                
                videoWindow.ShowDialog();
            }
            else if(AudioPlaybackCheckBox.Checked)
            {
                AudioVideoPlayback videoWindow = new AudioVideoPlayback(AudioPlaybackCheckBox.Checked, DestinationFilePaths);
                WMPLib.IWMPPlaylist playlist = videoWindow.axWindowsMediaPlayer1.playlistCollection.newPlaylist("PianoScrolls_Midi");
                WMPLib.IWMPMedia media;
                foreach (string file in DestinationFilePaths)
                {
                    media = videoWindow.axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
                videoWindow.axWindowsMediaPlayer1.currentPlaylist = playlist;

                videoWindow.ShowDialog();
            }
            //is this the proper way to end the program?
            System.Windows.Forms.Application.Exit();
         
        }

    }
}
