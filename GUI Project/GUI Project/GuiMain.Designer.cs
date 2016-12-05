namespace GUI_Project
{
    partial class MainGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunButton = new System.Windows.Forms.Button();
            this.MainUIPanel = new System.Windows.Forms.Panel();
            this.SingleBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuartetBox4 = new System.Windows.Forms.ComboBox();
            this.QuartetBox3 = new System.Windows.Forms.ComboBox();
            this.QuartetBox2 = new System.Windows.Forms.ComboBox();
            this.QuartetBox1 = new System.Windows.Forms.ComboBox();
            this.AudioPlaybackCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoPlaybackCheckBox = new System.Windows.Forms.CheckBox();
            this.DestOpenButton = new System.Windows.Forms.Button();
            this.UserDestFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserSourceFilePath = new System.Windows.Forms.Label();
            this.SourceOpenButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainUIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(471, 392);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainUIPanel
            // 
            this.MainUIPanel.BackColor = System.Drawing.Color.Azure;
            this.MainUIPanel.Controls.Add(this.SingleBox1);
            this.MainUIPanel.Controls.Add(this.radioButton2);
            this.MainUIPanel.Controls.Add(this.radioButton1);
            this.MainUIPanel.Controls.Add(this.label6);
            this.MainUIPanel.Controls.Add(this.label5);
            this.MainUIPanel.Controls.Add(this.label4);
            this.MainUIPanel.Controls.Add(this.label2);
            this.MainUIPanel.Controls.Add(this.QuartetBox4);
            this.MainUIPanel.Controls.Add(this.QuartetBox3);
            this.MainUIPanel.Controls.Add(this.QuartetBox2);
            this.MainUIPanel.Controls.Add(this.QuartetBox1);
            this.MainUIPanel.Controls.Add(this.AudioPlaybackCheckBox);
            this.MainUIPanel.Controls.Add(this.VideoPlaybackCheckBox);
            this.MainUIPanel.Controls.Add(this.DestOpenButton);
            this.MainUIPanel.Controls.Add(this.UserDestFilePath);
            this.MainUIPanel.Controls.Add(this.label1);
            this.MainUIPanel.Controls.Add(this.label3);
            this.MainUIPanel.Controls.Add(this.UserSourceFilePath);
            this.MainUIPanel.Controls.Add(this.SourceOpenButton);
            this.MainUIPanel.Location = new System.Drawing.Point(12, 98);
            this.MainUIPanel.Name = "MainUIPanel";
            this.MainUIPanel.Size = new System.Drawing.Size(534, 288);
            this.MainUIPanel.TabIndex = 2;
            this.MainUIPanel.Visible = false;
            // 
            // SingleBox1
            // 
            this.SingleBox1.FormattingEnabled = true;
            this.SingleBox1.Items.AddRange(new object[] {
            "1   Acoustic Grand Piano",
            "2  Bright Acoustic Piano",
            "3  Electric Grand Piano",
            "4  Honky-tonk Piano",
            "5  Electric Piano 1",
            "6  Electric Piano 2",
            "7  Harpsichord",
            "8  Clavi",
            "9  Celesta",
            "10  Glockenspiel",
            "11  Music Box",
            "12  Vibraphone",
            "13  Marimba",
            "14  Xylophone",
            "15  Tubular Bells",
            "16  Dulcimer",
            "17  Drawbar Organ",
            "18  Percussive Organ",
            "19  Rock Organ",
            "20  Church Organ",
            "21  Reed Organ",
            "22  Accordion",
            "23  Harmonica",
            "24  Tango Accordion",
            "25  Acoustic Guitar (nylon)",
            "26  Acoustic Guitar (steel)",
            "27  Electric Guitar (jazz)",
            "28  Electric Guitar (clean)",
            "29  Electric Guitar (muted)",
            "30  Overdriven Guitar",
            "31  Distortion Guitar",
            "32  Guitar harmonics",
            "33  Acoustic Bass",
            "34  Electric Bass (finger)",
            "35  Electric Bass (pick)",
            "36  Fretless Bass",
            "37  Slap Bass 1",
            "38  Slap Bass 2",
            "39  Synth Bass 1",
            "40  Synth Bass 2",
            "41  Violin",
            "42  Viola",
            "43  Cello",
            "44  Contrabass",
            "45  Tremolo Strings",
            "46  Pizzicato Strings",
            "47  Orchestral Harp",
            "48  Timpani",
            "49  String Ensemble 1",
            "50  String Ensemble 2",
            "51  SynthStrings 1",
            "52  SynthStrings 2",
            "53  Choir Aahs",
            "54  Voice Oohs",
            "55  Synth Voice",
            "56  Orchestra Hit",
            "57  Trumpet",
            "58  Trombone",
            "59  Tuba",
            "60  Muted Trumpet",
            "61  French Horn",
            "62  Brass Section",
            "63  SynthBrass 1",
            "64  SynthBrass 2",
            "65  Soprano Sax",
            "66  Alto Sax",
            "67  Tenor Sax",
            "68  Baritone Sax",
            "69  Oboe",
            "70  English Horn",
            "71  Bassoon",
            "72  Clarinet",
            "73  Piccolo",
            "74  Flute",
            "75  Recorder",
            "76  Pan Flute",
            "77  Blown Bottle",
            "78  Shakuhachi",
            "79  Whistle",
            "80  Ocarina",
            "81  Lead 1 (sthis.Quare)",
            "82  Lead 2 (sawtooth)",
            "83  Lead 3 (calliope)",
            "84  Lead 4 (chiff)",
            "85  Lead 5 (charang)",
            "86  Lead 6 (voice)",
            "87  Lead 7 (fifths)",
            "88  Lead 8 (bass + lead)",
            "89  Pad 1 (new age)",
            "90  Pad 2 (warm)",
            "91  Pad 3 (polysynth)",
            "92  Pad 4 (choir)",
            "93  Pad 5 (bowed)",
            "94  Pad 6 (metallic)",
            "95  Pad 7 (halo)",
            "96  Pad 8 (sweep)",
            "97  FX 1 (rain)",
            "98  FX 2 (soundtrack)",
            "99  FX 3 (crystal)",
            "100  FX 4 (atmosphere)",
            "101  FX 5 (brightness)",
            "102  FX 6 (goblins)",
            "103  FX 7 (echoes)",
            "104  FX 8 (sci-fi)",
            "105  Sitar",
            "106  Banjo",
            "107  Shamisen",
            "108  Koto",
            "109  Kalimba",
            "110  Bag pipe",
            "111  Fiddle",
            "112  Shanai",
            "113  Tinkle Bell",
            "114  Agogo",
            "115  Steel Drums",
            "116  Woodblock",
            "117  Taiko Drum",
            "118  Melodic Tom",
            "119  Synth Drum",
            "120  Reverse Cymbal",
            "121  Guitar Fret Noise",
            "122  Breath Noise",
            "123  Seashore",
            "124  Bird Tweet",
            "125  Telephone Ring",
            "126  Helicopter",
            "127  Applause",
            "128  Gunshot"});
            this.SingleBox1.Location = new System.Drawing.Point(80, 163);
            this.SingleBox1.Name = "SingleBox1";
            this.SingleBox1.Size = new System.Drawing.Size(176, 21);
            this.SingleBox1.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(109, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single Instrument Mode";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(369, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "Quartet Mode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Soprano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tenor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bass";
            // 
            // QuartetBox4
            // 
            this.QuartetBox4.Enabled = false;
            this.QuartetBox4.FormattingEnabled = true;
            this.QuartetBox4.Items.AddRange(new object[] {
            "1   Acoustic Grand Piano",
            "2  Bright Acoustic Piano",
            "3  Electric Grand Piano",
            "4  Honky-tonk Piano",
            "5  Electric Piano 1",
            "6  Electric Piano 2",
            "7  Harpsichord",
            "8  Clavi",
            "9  Celesta",
            "10  Glockenspiel",
            "11  Music Box",
            "12  Vibraphone",
            "13  Marimba",
            "14  Xylophone",
            "15  Tubular Bells",
            "16  Dulcimer",
            "17  Drawbar Organ",
            "18  Percussive Organ",
            "19  Rock Organ",
            "20  Church Organ",
            "21  Reed Organ",
            "22  Accordion",
            "23  Harmonica",
            "24  Tango Accordion",
            "25  Acoustic Guitar (nylon)",
            "26  Acoustic Guitar (steel)",
            "27  Electric Guitar (jazz)",
            "28  Electric Guitar (clean)",
            "29  Electric Guitar (muted)",
            "30  Overdriven Guitar",
            "31  Distortion Guitar",
            "32  Guitar harmonics",
            "33  Acoustic Bass",
            "34  Electric Bass (finger)",
            "35  Electric Bass (pick)",
            "36  Fretless Bass",
            "37  Slap Bass 1",
            "38  Slap Bass 2",
            "39  Synth Bass 1",
            "40  Synth Bass 2",
            "41  Violin",
            "42  Viola",
            "43  Cello",
            "44  Contrabass",
            "45  Tremolo Strings",
            "46  Pizzicato Strings",
            "47  Orchestral Harp",
            "48  Timpani",
            "49  String Ensemble 1",
            "50  String Ensemble 2",
            "51  SynthStrings 1",
            "52  SynthStrings 2",
            "53  Choir Aahs",
            "54  Voice Oohs",
            "55  Synth Voice",
            "56  Orchestra Hit",
            "57  Trumpet",
            "58  Trombone",
            "59  Tuba",
            "60  Muted Trumpet",
            "61  French Horn",
            "62  Brass Section",
            "63  SynthBrass 1",
            "64  SynthBrass 2",
            "65  Soprano Sax",
            "66  Alto Sax",
            "67  Tenor Sax",
            "68  Baritone Sax",
            "69  Oboe",
            "70  English Horn",
            "71  Bassoon",
            "72  Clarinet",
            "73  Piccolo",
            "74  Flute",
            "75  Recorder",
            "76  Pan Flute",
            "77  Blown Bottle",
            "78  Shakuhachi",
            "79  Whistle",
            "80  Ocarina",
            "81  Lead 1 (sthis.Quare)",
            "82  Lead 2 (sawtooth)",
            "83  Lead 3 (calliope)",
            "84  Lead 4 (chiff)",
            "85  Lead 5 (charang)",
            "86  Lead 6 (voice)",
            "87  Lead 7 (fifths)",
            "88  Lead 8 (bass + lead)",
            "89  Pad 1 (new age)",
            "90  Pad 2 (warm)",
            "91  Pad 3 (polysynth)",
            "92  Pad 4 (choir)",
            "93  Pad 5 (bowed)",
            "94  Pad 6 (metallic)",
            "95  Pad 7 (halo)",
            "96  Pad 8 (sweep)",
            "97  FX 1 (rain)",
            "98  FX 2 (soundtrack)",
            "99  FX 3 (crystal)",
            "100  FX 4 (atmosphere)",
            "101  FX 5 (brightness)",
            "102  FX 6 (goblins)",
            "103  FX 7 (echoes)",
            "104  FX 8 (sci-fi)",
            "105  Sitar",
            "106  Banjo",
            "107  Shamisen",
            "108  Koto",
            "109  Kalimba",
            "110  Bag pipe",
            "111  Fiddle",
            "112  Shanai",
            "113  Tinkle Bell",
            "114  Agogo",
            "115  Steel Drums",
            "116  Woodblock",
            "117  Taiko Drum",
            "118  Melodic Tom",
            "119  Synth Drum",
            "120  Reverse Cymbal",
            "121  Guitar Fret Noise",
            "122  Breath Noise",
            "123  Seashore",
            "124  Bird Tweet",
            "125  Telephone Ring",
            "126  Helicopter",
            "127  Applause",
            "128  Gunshot"});
            this.QuartetBox4.Location = new System.Drawing.Point(339, 244);
            this.QuartetBox4.Name = "QuartetBox4";
            this.QuartetBox4.Size = new System.Drawing.Size(176, 21);
            this.QuartetBox4.TabIndex = 11;
            // 
            // QuartetBox3
            // 
            this.QuartetBox3.Enabled = false;
            this.QuartetBox3.FormattingEnabled = true;
            this.QuartetBox3.Items.AddRange(new object[] {
            "1   Acoustic Grand Piano",
            "2  Bright Acoustic Piano",
            "3  Electric Grand Piano",
            "4  Honky-tonk Piano",
            "5  Electric Piano 1",
            "6  Electric Piano 2",
            "7  Harpsichord",
            "8  Clavi",
            "9  Celesta",
            "10  Glockenspiel",
            "11  Music Box",
            "12  Vibraphone",
            "13  Marimba",
            "14  Xylophone",
            "15  Tubular Bells",
            "16  Dulcimer",
            "17  Drawbar Organ",
            "18  Percussive Organ",
            "19  Rock Organ",
            "20  Church Organ",
            "21  Reed Organ",
            "22  Accordion",
            "23  Harmonica",
            "24  Tango Accordion",
            "25  Acoustic Guitar (nylon)",
            "26  Acoustic Guitar (steel)",
            "27  Electric Guitar (jazz)",
            "28  Electric Guitar (clean)",
            "29  Electric Guitar (muted)",
            "30  Overdriven Guitar",
            "31  Distortion Guitar",
            "32  Guitar harmonics",
            "33  Acoustic Bass",
            "34  Electric Bass (finger)",
            "35  Electric Bass (pick)",
            "36  Fretless Bass",
            "37  Slap Bass 1",
            "38  Slap Bass 2",
            "39  Synth Bass 1",
            "40  Synth Bass 2",
            "41  Violin",
            "42  Viola",
            "43  Cello",
            "44  Contrabass",
            "45  Tremolo Strings",
            "46  Pizzicato Strings",
            "47  Orchestral Harp",
            "48  Timpani",
            "49  String Ensemble 1",
            "50  String Ensemble 2",
            "51  SynthStrings 1",
            "52  SynthStrings 2",
            "53  Choir Aahs",
            "54  Voice Oohs",
            "55  Synth Voice",
            "56  Orchestra Hit",
            "57  Trumpet",
            "58  Trombone",
            "59  Tuba",
            "60  Muted Trumpet",
            "61  French Horn",
            "62  Brass Section",
            "63  SynthBrass 1",
            "64  SynthBrass 2",
            "65  Soprano Sax",
            "66  Alto Sax",
            "67  Tenor Sax",
            "68  Baritone Sax",
            "69  Oboe",
            "70  English Horn",
            "71  Bassoon",
            "72  Clarinet",
            "73  Piccolo",
            "74  Flute",
            "75  Recorder",
            "76  Pan Flute",
            "77  Blown Bottle",
            "78  Shakuhachi",
            "79  Whistle",
            "80  Ocarina",
            "81  Lead 1 (sthis.Quare)",
            "82  Lead 2 (sawtooth)",
            "83  Lead 3 (calliope)",
            "84  Lead 4 (chiff)",
            "85  Lead 5 (charang)",
            "86  Lead 6 (voice)",
            "87  Lead 7 (fifths)",
            "88  Lead 8 (bass + lead)",
            "89  Pad 1 (new age)",
            "90  Pad 2 (warm)",
            "91  Pad 3 (polysynth)",
            "92  Pad 4 (choir)",
            "93  Pad 5 (bowed)",
            "94  Pad 6 (metallic)",
            "95  Pad 7 (halo)",
            "96  Pad 8 (sweep)",
            "97  FX 1 (rain)",
            "98  FX 2 (soundtrack)",
            "99  FX 3 (crystal)",
            "100  FX 4 (atmosphere)",
            "101  FX 5 (brightness)",
            "102  FX 6 (goblins)",
            "103  FX 7 (echoes)",
            "104  FX 8 (sci-fi)",
            "105  Sitar",
            "106  Banjo",
            "107  Shamisen",
            "108  Koto",
            "109  Kalimba",
            "110  Bag pipe",
            "111  Fiddle",
            "112  Shanai",
            "113  Tinkle Bell",
            "114  Agogo",
            "115  Steel Drums",
            "116  Woodblock",
            "117  Taiko Drum",
            "118  Melodic Tom",
            "119  Synth Drum",
            "120  Reverse Cymbal",
            "121  Guitar Fret Noise",
            "122  Breath Noise",
            "123  Seashore",
            "124  Bird Tweet",
            "125  Telephone Ring",
            "126  Helicopter",
            "127  Applause",
            "128  Gunshot"});
            this.QuartetBox3.Location = new System.Drawing.Point(339, 217);
            this.QuartetBox3.Name = "QuartetBox3";
            this.QuartetBox3.Size = new System.Drawing.Size(176, 21);
            this.QuartetBox3.TabIndex = 10;
            // 
            // QuartetBox2
            // 
            this.QuartetBox2.Enabled = false;
            this.QuartetBox2.FormattingEnabled = true;
            this.QuartetBox2.Items.AddRange(new object[] {
            "1   Acoustic Grand Piano",
            "2  Bright Acoustic Piano",
            "3  Electric Grand Piano",
            "4  Honky-tonk Piano",
            "5  Electric Piano 1",
            "6  Electric Piano 2",
            "7  Harpsichord",
            "8  Clavi",
            "9  Celesta",
            "10  Glockenspiel",
            "11  Music Box",
            "12  Vibraphone",
            "13  Marimba",
            "14  Xylophone",
            "15  Tubular Bells",
            "16  Dulcimer",
            "17  Drawbar Organ",
            "18  Percussive Organ",
            "19  Rock Organ",
            "20  Church Organ",
            "21  Reed Organ",
            "22  Accordion",
            "23  Harmonica",
            "24  Tango Accordion",
            "25  Acoustic Guitar (nylon)",
            "26  Acoustic Guitar (steel)",
            "27  Electric Guitar (jazz)",
            "28  Electric Guitar (clean)",
            "29  Electric Guitar (muted)",
            "30  Overdriven Guitar",
            "31  Distortion Guitar",
            "32  Guitar harmonics",
            "33  Acoustic Bass",
            "34  Electric Bass (finger)",
            "35  Electric Bass (pick)",
            "36  Fretless Bass",
            "37  Slap Bass 1",
            "38  Slap Bass 2",
            "39  Synth Bass 1",
            "40  Synth Bass 2",
            "41  Violin",
            "42  Viola",
            "43  Cello",
            "44  Contrabass",
            "45  Tremolo Strings",
            "46  Pizzicato Strings",
            "47  Orchestral Harp",
            "48  Timpani",
            "49  String Ensemble 1",
            "50  String Ensemble 2",
            "51  SynthStrings 1",
            "52  SynthStrings 2",
            "53  Choir Aahs",
            "54  Voice Oohs",
            "55  Synth Voice",
            "56  Orchestra Hit",
            "57  Trumpet",
            "58  Trombone",
            "59  Tuba",
            "60  Muted Trumpet",
            "61  French Horn",
            "62  Brass Section",
            "63  SynthBrass 1",
            "64  SynthBrass 2",
            "65  Soprano Sax",
            "66  Alto Sax",
            "67  Tenor Sax",
            "68  Baritone Sax",
            "69  Oboe",
            "70  English Horn",
            "71  Bassoon",
            "72  Clarinet",
            "73  Piccolo",
            "74  Flute",
            "75  Recorder",
            "76  Pan Flute",
            "77  Blown Bottle",
            "78  Shakuhachi",
            "79  Whistle",
            "80  Ocarina",
            "81  Lead 1 (sthis.Quare)",
            "82  Lead 2 (sawtooth)",
            "83  Lead 3 (calliope)",
            "84  Lead 4 (chiff)",
            "85  Lead 5 (charang)",
            "86  Lead 6 (voice)",
            "87  Lead 7 (fifths)",
            "88  Lead 8 (bass + lead)",
            "89  Pad 1 (new age)",
            "90  Pad 2 (warm)",
            "91  Pad 3 (polysynth)",
            "92  Pad 4 (choir)",
            "93  Pad 5 (bowed)",
            "94  Pad 6 (metallic)",
            "95  Pad 7 (halo)",
            "96  Pad 8 (sweep)",
            "97  FX 1 (rain)",
            "98  FX 2 (soundtrack)",
            "99  FX 3 (crystal)",
            "100  FX 4 (atmosphere)",
            "101  FX 5 (brightness)",
            "102  FX 6 (goblins)",
            "103  FX 7 (echoes)",
            "104  FX 8 (sci-fi)",
            "105  Sitar",
            "106  Banjo",
            "107  Shamisen",
            "108  Koto",
            "109  Kalimba",
            "110  Bag pipe",
            "111  Fiddle",
            "112  Shanai",
            "113  Tinkle Bell",
            "114  Agogo",
            "115  Steel Drums",
            "116  Woodblock",
            "117  Taiko Drum",
            "118  Melodic Tom",
            "119  Synth Drum",
            "120  Reverse Cymbal",
            "121  Guitar Fret Noise",
            "122  Breath Noise",
            "123  Seashore",
            "124  Bird Tweet",
            "125  Telephone Ring",
            "126  Helicopter",
            "127  Applause",
            "128  Gunshot"});
            this.QuartetBox2.Location = new System.Drawing.Point(339, 190);
            this.QuartetBox2.Name = "QuartetBox2";
            this.QuartetBox2.Size = new System.Drawing.Size(176, 21);
            this.QuartetBox2.TabIndex = 9;
            // 
            // QuartetBox1
            // 
            this.QuartetBox1.Enabled = false;
            this.QuartetBox1.FormattingEnabled = true;
            this.QuartetBox1.Items.AddRange(new object[] {
            "1   Acoustic Grand Piano",
            "2  Bright Acoustic Piano",
            "3  Electric Grand Piano",
            "4  Honky-tonk Piano",
            "5  Electric Piano 1",
            "6  Electric Piano 2",
            "7  Harpsichord",
            "8  Clavi",
            "9  Celesta",
            "10  Glockenspiel",
            "11  Music Box",
            "12  Vibraphone",
            "13  Marimba",
            "14  Xylophone",
            "15  Tubular Bells",
            "16  Dulcimer",
            "17  Drawbar Organ",
            "18  Percussive Organ",
            "19  Rock Organ",
            "20  Church Organ",
            "21  Reed Organ",
            "22  Accordion",
            "23  Harmonica",
            "24  Tango Accordion",
            "25  Acoustic Guitar (nylon)",
            "26  Acoustic Guitar (steel)",
            "27  Electric Guitar (jazz)",
            "28  Electric Guitar (clean)",
            "29  Electric Guitar (muted)",
            "30  Overdriven Guitar",
            "31  Distortion Guitar",
            "32  Guitar harmonics",
            "33  Acoustic Bass",
            "34  Electric Bass (finger)",
            "35  Electric Bass (pick)",
            "36  Fretless Bass",
            "37  Slap Bass 1",
            "38  Slap Bass 2",
            "39  Synth Bass 1",
            "40  Synth Bass 2",
            "41  Violin",
            "42  Viola",
            "43  Cello",
            "44  Contrabass",
            "45  Tremolo Strings",
            "46  Pizzicato Strings",
            "47  Orchestral Harp",
            "48  Timpani",
            "49  String Ensemble 1",
            "50  String Ensemble 2",
            "51  SynthStrings 1",
            "52  SynthStrings 2",
            "53  Choir Aahs",
            "54  Voice Oohs",
            "55  Synth Voice",
            "56  Orchestra Hit",
            "57  Trumpet",
            "58  Trombone",
            "59  Tuba",
            "60  Muted Trumpet",
            "61  French Horn",
            "62  Brass Section",
            "63  SynthBrass 1",
            "64  SynthBrass 2",
            "65  Soprano Sax",
            "66  Alto Sax",
            "67  Tenor Sax",
            "68  Baritone Sax",
            "69  Oboe",
            "70  English Horn",
            "71  Bassoon",
            "72  Clarinet",
            "73  Piccolo",
            "74  Flute",
            "75  Recorder",
            "76  Pan Flute",
            "77  Blown Bottle",
            "78  Shakuhachi",
            "79  Whistle",
            "80  Ocarina",
            "81  Lead 1 (sthis.Quare)",
            "82  Lead 2 (sawtooth)",
            "83  Lead 3 (calliope)",
            "84  Lead 4 (chiff)",
            "85  Lead 5 (charang)",
            "86  Lead 6 (voice)",
            "87  Lead 7 (fifths)",
            "88  Lead 8 (bass + lead)",
            "89  Pad 1 (new age)",
            "90  Pad 2 (warm)",
            "91  Pad 3 (polysynth)",
            "92  Pad 4 (choir)",
            "93  Pad 5 (bowed)",
            "94  Pad 6 (metallic)",
            "95  Pad 7 (halo)",
            "96  Pad 8 (sweep)",
            "97  FX 1 (rain)",
            "98  FX 2 (soundtrack)",
            "99  FX 3 (crystal)",
            "100  FX 4 (atmosphere)",
            "101  FX 5 (brightness)",
            "102  FX 6 (goblins)",
            "103  FX 7 (echoes)",
            "104  FX 8 (sci-fi)",
            "105  Sitar",
            "106  Banjo",
            "107  Shamisen",
            "108  Koto",
            "109  Kalimba",
            "110  Bag pipe",
            "111  Fiddle",
            "112  Shanai",
            "113  Tinkle Bell",
            "114  Agogo",
            "115  Steel Drums",
            "116  Woodblock",
            "117  Taiko Drum",
            "118  Melodic Tom",
            "119  Synth Drum",
            "120  Reverse Cymbal",
            "121  Guitar Fret Noise",
            "122  Breath Noise",
            "123  Seashore",
            "124  Bird Tweet",
            "125  Telephone Ring",
            "126  Helicopter",
            "127  Applause",
            "128  Gunshot"});
            this.QuartetBox1.Location = new System.Drawing.Point(339, 163);
            this.QuartetBox1.Name = "QuartetBox1";
            this.QuartetBox1.Size = new System.Drawing.Size(176, 21);
            this.QuartetBox1.TabIndex = 8;
            // 
            // AudioPlaybackCheckBox
            // 
            this.AudioPlaybackCheckBox.AutoSize = true;
            this.AudioPlaybackCheckBox.Location = new System.Drawing.Point(128, 122);
            this.AudioPlaybackCheckBox.Name = "AudioPlaybackCheckBox";
            this.AudioPlaybackCheckBox.Size = new System.Drawing.Size(128, 17);
            this.AudioPlaybackCheckBox.TabIndex = 7;
            this.AudioPlaybackCheckBox.Text = "Use Generated Audio";
            this.AudioPlaybackCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoPlaybackCheckBox
            // 
            this.VideoPlaybackCheckBox.AutoSize = true;
            this.VideoPlaybackCheckBox.Location = new System.Drawing.Point(6, 122);
            this.VideoPlaybackCheckBox.Name = "VideoPlaybackCheckBox";
            this.VideoPlaybackCheckBox.Size = new System.Drawing.Size(100, 17);
            this.VideoPlaybackCheckBox.TabIndex = 6;
            this.VideoPlaybackCheckBox.Text = "Video Playback";
            this.VideoPlaybackCheckBox.UseVisualStyleBackColor = true;
            // 
            // DestOpenButton
            // 
            this.DestOpenButton.Location = new System.Drawing.Point(440, 85);
            this.DestOpenButton.Name = "DestOpenButton";
            this.DestOpenButton.Size = new System.Drawing.Size(75, 23);
            this.DestOpenButton.TabIndex = 5;
            this.DestOpenButton.Text = "Open";
            this.DestOpenButton.UseVisualStyleBackColor = true;
            this.DestOpenButton.Click += new System.EventHandler(this.DestOpenButton_Click);
            // 
            // UserDestFilePath
            // 
            this.UserDestFilePath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserDestFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserDestFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDestFilePath.Location = new System.Drawing.Point(6, 84);
            this.UserDestFilePath.Name = "UserDestFilePath";
            this.UserDestFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserDestFilePath.TabIndex = 4;
            this.UserDestFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the destination of your output file(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please select the file you would like to convert";
            // 
            // UserSourceFilePath
            // 
            this.UserSourceFilePath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserSourceFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserSourceFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSourceFilePath.Location = new System.Drawing.Point(6, 32);
            this.UserSourceFilePath.Name = "UserSourceFilePath";
            this.UserSourceFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserSourceFilePath.TabIndex = 1;
            this.UserSourceFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceOpenButton
            // 
            this.SourceOpenButton.Location = new System.Drawing.Point(440, 33);
            this.SourceOpenButton.Name = "SourceOpenButton";
            this.SourceOpenButton.Size = new System.Drawing.Size(75, 23);
            this.SourceOpenButton.TabIndex = 0;
            this.SourceOpenButton.Text = "Open";
            this.SourceOpenButton.UseVisualStyleBackColor = true;
            this.SourceOpenButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI_Project.Properties.Resources.MeasuredSolutionsLogo;
            this.Logo.Location = new System.Drawing.Point(96, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(360, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(558, 427);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.MainUIPanel);
            this.Controls.Add(this.RunButton);
            this.Name = "MainGui";
            this.Text = "Piano Scroll Converter";
            this.MainUIPanel.ResumeLayout(false);
            this.MainUIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel MainUIPanel;
        private System.Windows.Forms.Button SourceOpenButton;
        private System.Windows.Forms.Label UserSourceFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DestOpenButton;
        private System.Windows.Forms.Label UserDestFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox VideoPlaybackCheckBox;
        private System.Windows.Forms.CheckBox AudioPlaybackCheckBox;
        private System.Windows.Forms.ComboBox QuartetBox4;
        private System.Windows.Forms.ComboBox QuartetBox3;
        private System.Windows.Forms.ComboBox QuartetBox2;
        private System.Windows.Forms.ComboBox QuartetBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SingleBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

