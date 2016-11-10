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
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "..\\..\\CV\\ScrollReader_CV.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = file_path;
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
        static void LaunchMIDI(string notes_file, string dest_file)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "..\\..\\CV\\MidiConverter.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = notes_file + " " + dest_file;
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
                    dest_file += "mid";
                    DestinationFileNames.Add(dest_file);
                }
                OpenPressed = true;
                

                
            }
           
        }

        private void DestOpenButton_Click(object sender, EventArgs e)
        {
            
            /*
            SaveFileDialog SaveFile = new SaveFileDialog();
            //OpenFile.Multiselect = true;
            SaveFile.Filter = "MIDI Files (*.smf) |*.smf";
            SaveFile.ShowDialog();
            if (SaveFile.FileName != "")
            {
                UserDestFilePath.Text = SaveFile.FileName;
                DestFileName = SaveFile.FileName;
                SavePressed = true;
            }
            */
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
                foreach(string dest_file in DestinationFileNames)
                {
                    string dest_path = DestFolderName  + dest_file;
                    DestinationFilePaths.Add(dest_path);

                }
                int index = 0;
                foreach(string file in SourceFileNames)
                {
                    LaunchCV(file);
                    //LaunchMIDI("..//bin//Debug//temporaryOutputFileForReading.txt", DestinationFilePaths[index]);
                    //ParseFile("temporaryOutputFileForReading.txt", DestinationFilePaths[index]);
                    //The result of Angelo's code is now in a file called:______

                    //Need to run MIDI code on each of the file that CV generates
                    
                    //Need to save the midi files as the corresponding DestinationFilePath

                    //Probably need to add a case where the file already exists. 
                    //We'll likely just append a '_1' or something to the end

                    //increment the index so we know which DestinationFilePath to use
                    index++;
                }
                
            }
            //If the user wants video playback
            if(VideoPlaybackCheckBox.Checked)
            {
                AudioVideoPlayback videoWindow = new AudioVideoPlayback();
                WMPLib.IWMPPlaylist playlist = videoWindow.axWindowsMediaPlayer1.playlistCollection.newPlaylist("PianoScrolls");
                WMPLib.IWMPMedia media;
                foreach (string file in SourceFileNames)
                {
                    media = videoWindow.axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
                videoWindow.axWindowsMediaPlayer1.currentPlaylist = playlist;
                if(AudioPlaybackCheckBox.Checked)
                {
                    //videoWindow.axWindowsMediaPlayer1.settings.volume = 0;
                    videoWindow.use_midi_audio = true;
                    videoWindow.MidiList = DestinationFilePaths;
                    //need to set Midilist to list of midi file paths
                    //videoWindow.MidiList
                    //and set a bool in videoWindow to indicate that the file should be muted
                    //and the midi file should be played instead
                    //One possible solution for playing the midi file is to make an invisible media player
                    //that will play the midi file (need to test if wmp can play a midi file) and use the first
                    //player to play the video. Need to test that once we have some MIDI files to play with
                }
                videoWindow.ShowDialog();
            }
            //is this the proper way to end the program?
            System.Windows.Forms.Application.Exit();
          


        }

    }
}
