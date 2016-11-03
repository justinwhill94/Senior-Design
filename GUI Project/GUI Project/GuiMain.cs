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
        }
        string FileName;
        private void NextButton_Click(object sender, EventArgs e)
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
            
        }
        private void Search_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.ShowDialog();
            if (OpenFile.FileName != "")
            {
                NextButton.Enabled = true;
                UserFileNameLabel.Text = OpenFile.FileName;
                FileName = OpenFile.FileName;
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
