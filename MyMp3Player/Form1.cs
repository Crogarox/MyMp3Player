using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMp3Player
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
            	ofd.Multiselect = true;
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                	//mp3Player = new Mp3Player();
                	audioLbx.Items.Clear();
                	foreach (String file in ofd.FileNames) 
        			{
                		
                		audioLbx.Items.Add(file);
                	}
                	mp3Player.close();
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }
        void stopBtn_Click(object sender, EventArgs e)
		{
			 mp3Player.stop();
		}

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
		void AudioLbxSelectedIndexChanged(object sender, EventArgs e)
		{
			mp3Player.close();
			mp3Player.open(audioLbx.Items[audioLbx.SelectedIndex].ToString());
			mp3Player.play();
		}
		
		private void prevBtn_Click(object sender, EventArgs e)
		{
			if(audioLbx.SelectedIndex > 0)
			{
				audioLbx.SelectedIndex = audioLbx.SelectedIndex - 1;
			}
		}
		private void nextBtn_Click(object sender, EventArgs e)
		{
			if(audioLbx.SelectedIndex < audioLbx.Items.Count -1)
			{
				audioLbx.SelectedIndex = audioLbx.SelectedIndex + 1;
			}
		}
		
    }
}
