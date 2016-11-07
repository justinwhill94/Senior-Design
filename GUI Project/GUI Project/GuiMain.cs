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

namespace GUI_Project
{
    
    
    public partial class MainGui : Form
    {
        
        //[DllImport("C:\\Users\\Matthew\\Desktop\\UK\\Fall 2016\\Senior-Design-GUI\\GUI Project\\GUI Project\\CV\\ConsoleApplication1.dll",  CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        //public static extern void CVmain(string filePath);
       //[DllImport("C:\\Users\\Matthew\\Desktop\\TestLibrary.dll",  CallingConvention = CallingConvention.Cdecl)]
       // public static extern double TEST_Add(double a, double b);
        static void LaunchCommandLineApp(string file_path)
        {
            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:\\CV_test\\ConsoleApplication1.exe";
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
                int x = 2;
            }
        }
        public MainGui()
        {
            
            InitializeComponent();
            MainUIPanel.Visible = true;
        }
        List<string> SourceFileNames = new List<string>();
        string DestFileName;
       
        private void Search_Click(object sender, EventArgs e)
        {
            //Need to specify which files can be chosen
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Filter = "Videos (*.avi) | *.avi|" + "All files (*.*)|*.*";
            OpenFile.ShowDialog();
           
            
            if (OpenFile.FileName != "")
            {
                SourceFileNames = new List<string>();
                foreach(string file in OpenFile.FileNames)
                {
                    UserSourceFilePath.Text += file + ";";
                    SourceFileNames.Add(file);
                }
                //UserSourceFilePath.Text = OpenFile.FileName;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.ShowDialog();
            if (OpenFile.FileName != "")
            {
                UserDestFilePath.Text = OpenFile.FileName;
                DestFileName = OpenFile.FileName;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
          //  CVmain(SourceFileNames[0]);
         //  double a =  TEST_Add(1.0, 2.0);
            LaunchCommandLineApp(SourceFileNames[0]);

        }

    }
}
