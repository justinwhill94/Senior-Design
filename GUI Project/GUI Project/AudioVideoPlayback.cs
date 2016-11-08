using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class AudioVideoPlayback : Form
    {
        
        public AudioVideoPlayback()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.enableContextMenu = false;
            
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
           /* switch(e.newState)
            {
                case 1: //stopped
                    break;
                case 2: //paused
                    break;
                case 3: //playing
                    break;

            }*/
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
