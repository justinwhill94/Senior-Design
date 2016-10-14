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

namespace GUI_Project
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
            MainUIPanel.Visible = true;
        }
        List<string> SourceFileNames = new List<string>();
        string DestFileName;
       /* private void NextButton_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                NextButton.Enabled = false;
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel3.Visible = true;
                WithPlay.Select();
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                NextButton.Visible = false;
                var Proc = Process.Start(FileName);
                panel4.Visible = true;
                CloseButton.Visible = true;
            } 
            
        }*/
        private void Search_Click(object sender, EventArgs e)
        {
            //Need to specify which files can be chosen
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Filter = "Videos (*.mp4) | *.mp4|" + "All files (*.*)|*.*";
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

    }
}
