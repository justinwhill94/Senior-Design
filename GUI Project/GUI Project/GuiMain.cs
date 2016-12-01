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
using System.IO;

namespace GUI_Project
{
    
    
    public partial class MainGui : Form
    {
        public int instrument_mode = 0; //0 for single, 1 for quartet
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
                    MessageBox.Show("There was a problem with the Computer Vision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //Need to end conversion and display an error MessageBox
                }

        }

        static void LaunchMIDI(string notes_file, string dest_file, int i_1, int i_2, int i_3, int i_4)
        {
            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "..\\..\\CV\\MidiConverter.exe";
            startInfo.CreateNoWindow = true;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "\"" + notes_file + "\"" + " " + "\"" + dest_file + "\""+ " 1 " + i_1 + ' ' + i_2 + ' ' + i_3 + ' ' + i_4 + " ";
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
                MessageBox.Show("There was a problem with the MIDI conversion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        List<string> NewFilePaths = new List<string>();
        
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
            //if the user hasn't selected a source or destination file, display an error message
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
                    NewFilePaths.Add(dest_path);

                }
                int index = 0;
                
                foreach(string file in SourceFileNames)
                {
                    string original_path = DestinationFilePaths[index];
                    Cursor.Current = Cursors.WaitCursor;
                    //Run the computer vision program
                    LaunchCV(file);
                    //Run the Midi generation program
                    int inst1, inst2, inst3, inst4;
                    if (instrument_mode == 1)
                    {
                        inst1 = QuartetBox1.SelectedIndex;
                        if (inst1 == 0)
                            inst1 = 1;
                        inst2 = QuartetBox2.SelectedIndex;
                        if (inst2 == 0)
                            inst2 = 1;
                        inst3 = QuartetBox3.SelectedIndex;
                        if (inst3 == 0)
                            inst3 = 1;
                        inst4 = QuartetBox4.SelectedIndex;
                        if (inst4 == 0)
                            inst4 = 1;
                    }
                    else
                    {
                        inst1 = SingleBox1.SelectedIndex;
                        if (inst1 == 0)
                            inst1 = 1;
                        inst2 = inst1;
                        inst3 = inst1;
                        inst4 = inst1;        
                    }
                    /*bool file_name_exists = true;
                    int i = 1;
                    string file_str = DestinationFilePaths[index];
                    while(file_name_exists)
                    {      
                        
                        if(System.IO.File.Exists(file_str))
                        {
                            file_str = DestinationFilePaths[index].Substring(0, DestinationFilePaths[index].IndexOf(".mid")) + " (" + i + ").mid";
                            i++;
                        }
                        else
                        {
                            file_name_exists = false;
                        }
                    }
                     DestinationFilePaths[index] = file_str;*/
                    //DestinationFilePaths[index] = MakeUnique(DestinationFilePaths[index]);
                    int count = 1;
                    string fullPath = DestinationFilePaths[index];
                    string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
                    string extension = Path.GetExtension(fullPath);
                    string path = Path.GetDirectoryName(fullPath);
                    string newFullPath = fullPath;

                    while (File.Exists(newFullPath))
                    {
                        string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                        newFullPath = Path.Combine(path, tempFileName + extension);
                    }
                    DestinationFilePaths[index] = newFullPath;
                    LaunchMIDI(".\\temporaryOutputFileForReading.txt", DestinationFilePaths[index], inst1, inst2, inst3, inst4);
                    Cursor.Current = Cursors.Arrow;

                    //increment the index so we know which DestinationFilePath to use
                    NewFilePaths[index] = DestinationFilePaths[index];
                    DestinationFilePaths[index] = original_path;
                    index++;
                }
                
                
            }
            //If the user wants video playback
            if(VideoPlaybackCheckBox.Checked)
            {
                //create the playback form and fill the primary media player's playlist with the piano scroll videos
                AudioVideoPlayback videoWindow = new AudioVideoPlayback(AudioPlaybackCheckBox.Checked, NewFilePaths);
                WMPLib.IWMPPlaylist playlist = videoWindow.axWindowsMediaPlayer1.playlistCollection.newPlaylist("PianoScrolls_Original");
                WMPLib.IWMPMedia media;
                foreach (string file in SourceFileNames)
                {
                    media = videoWindow.axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
                videoWindow.axWindowsMediaPlayer1.currentPlaylist = playlist;
                
                videoWindow.ShowDialog();
                videoWindow.axWindowsMediaPlayer1.Ctlcontrols.stop();
                videoWindow.axWindowsMediaPlayerMidi.Ctlcontrols.stop();
                videoWindow.Close();
            }
            //If the user doesn't want video playback, but does want audio playback
            //open up the playback form and play the midi audio file on the main media
            //player.
            else if(AudioPlaybackCheckBox.Checked)
            {
                AudioVideoPlayback videoWindow = new AudioVideoPlayback(AudioPlaybackCheckBox.Checked, NewFilePaths);
                WMPLib.IWMPPlaylist playlist = videoWindow.axWindowsMediaPlayer1.playlistCollection.newPlaylist("PianoScrolls_Midi");
                WMPLib.IWMPMedia media;
                foreach (string file in NewFilePaths)
                {
                    media = videoWindow.axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
                videoWindow.axWindowsMediaPlayer1.currentPlaylist = playlist;

                videoWindow.ShowDialog();
                //videoWindow.axWindowsMediaPlayer1.Ctlcontrols.stop();
                //videoWindow.axWindowsMediaPlayerMidi.Ctlcontrols.stop();
                videoWindow.Close();
            }
            
            
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QuartetBox1.Enabled = true;
            QuartetBox2.Enabled = true;
            QuartetBox3.Enabled = true;
            QuartetBox4.Enabled = true;
            SingleBox1.Enabled = false;
            instrument_mode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            QuartetBox1.Enabled = false;
            QuartetBox2.Enabled = false;
            QuartetBox3.Enabled = false;
            QuartetBox4.Enabled = false;
            SingleBox1.Enabled = true;
            instrument_mode = 0;
        }


    }
}
