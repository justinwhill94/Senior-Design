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
        
        public bool use_midi;
        private void video_StateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(e.newState == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }
        private void audio_StateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        public AudioVideoPlayback(bool use_midi_audio, List<string> MidiList)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(video_StateChange);
            axWindowsMediaPlayerMidi.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(audio_StateChange);
            use_midi = use_midi_audio;
            //axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayerMidi.uiMode = "invisible";
            axWindowsMediaPlayer1.enableContextMenu = false;
            axWindowsMediaPlayerMidi.enableContextMenu = false;
            
            //axWindowsMediaPlayerMidi.settings.volume = 0;
            if(use_midi_audio)
            {
                //axWindowsMediaPlayer1.settings.volume = 0;
                axWindowsMediaPlayer1.settings.mute = true;
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

        private void PlayButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
            if (use_midi)
                axWindowsMediaPlayerMidi.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            if (use_midi)
                axWindowsMediaPlayerMidi.Ctlcontrols.pause();
        }

        private void SwitchAudioButton_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayerMidi.settings.mute = !(axWindowsMediaPlayerMidi.settings.mute);
            axWindowsMediaPlayer1.settings.mute = !(axWindowsMediaPlayer1.settings.mute);
        }
    }
}
