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
        
       // [DllImport("C:\\CV_test\\TestDLLTHing.dll",  CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        //public static extern int Testmain(string input);

        static void LaunchCommandLineApp(string file_path)
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
        public MainGui()
        {
            
            InitializeComponent();
            MainUIPanel.Visible = true;
        }

        List<string> SourceFileNames = new List<string>();
        string DestFolderName;
        bool OpenPressed = false;
        bool SavePressed = false;
        
        private void Search_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Filter = "AVI Videos (*.avi) | *.avi";
            OpenFile.ShowDialog();
           
            
            if (OpenFile.FileName != "")
            {
                SourceFileNames.Clear();
                UserSourceFilePath.Text = "";
                SourceFileNames = new List<string>();
                foreach(string file in OpenFile.FileNames)
                {
                    UserSourceFilePath.Text += file + ";";
                    SourceFileNames.Add(file);
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
                foreach(string file in SourceFileNames)
                {
                    LaunchCommandLineApp(file);
                    //The result of Angelo's code is now in a file called:______
                    //Need to run Joe's code on each of the files that Angelo 
                    //generates
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
                    videoWindow.axWindowsMediaPlayer1.settings.volume = 0;
                    //need to set Midilist to list of midi file paths
                    //videoWindow.MidiList
                }
                videoWindow.ShowDialog();
            }
            //is this the proper way to end the program?
            System.Windows.Forms.Application.Exit();
          


        }

    }
}
