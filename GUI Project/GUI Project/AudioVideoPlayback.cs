using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GUI_Project
{
    public partial class AudioVideoPlayback : Form
    {
        public bool use_midi_audio = false;
        public AudioVideoPlayback()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayerMidi.uiMode = "invisible";
            axWindowsMediaPlayer1.enableContextMenu = false;
            if(use_midi_audio)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayerMidi.playlistCollection.newPlaylist("PianoScrolls_Midi");
                WMPLib.IWMPMedia media;
                foreach (string file in MidiList)
                {
                    media = axWindowsMediaPlayerMidi.newMedia(file);
                    playlist.appendItem(media);
                }
                axWindowsMediaPlayerMidi.currentPlaylist = playlist;
            }
            else
            {
                axWindowsMediaPlayerMidi.settings.volume = 0;
            }
            
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
            if (use_midi_audio)
                axWindowsMediaPlayerMidi.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            if (use_midi_audio)
                axWindowsMediaPlayerMidi.Ctlcontrols.pause();
        }
    }
}
