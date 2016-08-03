using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_melody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration= Victorina.musicDuration;

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0)
                GameOver();
            else
            {
                timer1.Start();
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                wmp.URL = Victorina.list[n];
                //wmp.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lblMelodyCount.Text = Victorina.list.Count.ToString();
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void wmp_Enter(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameOver();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }

        void GamePause()
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }

        void GameOver()
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }


        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Player 1";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Player 2";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void wmp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (wmp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    wmp.Ctlcontrols.currentPosition = rnd.Next(0, (int)wmp.currentMedia.duration / 2);
        }
    }
}
