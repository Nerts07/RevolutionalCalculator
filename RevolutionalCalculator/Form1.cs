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

namespace RevolutionalCalculator
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        string[] files, paths;
        int x = 0;
        private bool isremain = false;
        private bool isplaying = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Favic_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPlayMusic(object sender, EventArgs e)
        {

            if (paths != null && paths.Length > 0)
            {
                player.URL = paths[0];
                player.controls.play();
                lbl_msg.Text = "Playing: " + track_listed.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No Music Today?? Select The Music From Your Potato PC Pojaluysta");
            }

        }

        private void PauseBtn(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void Resume(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = "0";
            result = 0;
        }

        private void PnlHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtDisplay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_listed.SelectedIndex];
            player.controls.play();
            lbl_msg.Text = "Playing: " + track_listed.SelectedItem.ToString();
            timer1.Start();
            trackBar1.Value = 80;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (track_listed.SelectedIndex<track_listed.Items.Count-1)
            {
                track_listed.SelectedIndex += 1;
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (track_listed.SelectedIndex>0)
            {
                track_listed.SelectedIndex -= 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.controls.currentItem.duration;
                progressBar1.Value = (int)player.controls.currentPosition;
            }

            lbl_track_start.Text = player.controls.currentPositionString;
            lbl_track_end.Text = player.controls.currentItem.durationString.ToString();

            if (!isremain)
            {
                lbl_track_end.Text = player.controls.currentItem.durationString.ToString();
            }
        }

        private void remain(object sender, EventArgs e)
        {   
            isremain = true;
            double duration = player.controls.currentItem.duration;
            double currentPosition = player.controls.currentPosition;
            double remainingTime = duration - currentPosition;

            TimeSpan time = TimeSpan.FromSeconds(remainingTime);
            string str = time.ToString(@"mm\:ss");

            lbl_track_end.Text = str;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
        }


        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        private void BtnMethOperats(object sender, EventArgs e)
        {
            if (result != 0)
            {
                buttonEqual.PerformClick();

            } else
            {
                result = double.Parse(TxtDisplay1.Text);
            }

            Button button = (Button)sender;

            operation = button.Text;
            enterValue = true;
            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay1.Text = fstNum = $"{result}{operation}";
                TxtDisplay1.Text = string.Empty;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay1.Text;

            TxtDisplay2.Text = $"{TxtDisplay2} {TxtDisplay1} =";
            if (TxtDisplay1.Text != string.Empty)
            {
                if(TxtDisplay1.Text == "0") TxtDisplay2.Text = string.Empty;

                if (operation == "+")
                {
                    TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString();
                    result = 0;
                }
                if (operation == "-")
                {
                    TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString();
                    result = 0;
                }
                if (operation == "/")
                {
                    TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString();
                    result = 0;
                }
                if (operation == "X")
                {
                    TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString();
                    result = 0;
                }
                else
                {
                    TxtDisplay1.Text = $"{TxtDisplay1.Text}";
                }

            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if(TxtDisplay1.Text == "0" || enterValue)
            {
                TxtDisplay1.Text = string.Empty;
            }

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains("."))
                {
                    TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
                }
               
            }
            else TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
        }

        private void ChangeMusic(object sender, EventArgs e)
        {
            if (isplaying)
            {
                MessageBox.Show("You can't select music anymore, because of bugs, i cant fix them, " +
                    "so, i need to limit you, thx for understandable, have a great day.        (Isa)");
                return;
            }


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                for (; x < files.Length; x++)
                {
                    track_listed.Items.Add(files[x]);
                }
                isplaying = true;

            }
        }
    }
}
