using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ArcadeGame
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            countdown.Visible = true;
            SoundPlayer dingPlayer = new SoundPlayer(Properties.Resources.ding);
            dingPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "2";
            dingPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "1";
            dingPlayer.Play();

            
            Refresh();
            Thread.Sleep(1000);
            go.Visible = true;
            this.BackColor = Color.Green;
            countdown.Visible = false;
            SoundPlayer zombiebackPlayer = new SoundPlayer(Properties.Resources.zombieback);
            zombiebackPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            SoundPlayer shotgunPlayer = new SoundPlayer(Properties.Resources.shotgun);
            shotgunPlayer.Play();

            Refresh();
            Thread.Sleep(900);
            SoundPlayer zombiepainPlayer = new SoundPlayer(Properties.Resources.zombiepain);
            zombiepainPlayer.Play();





        }

        private void go_Click(object sender, EventArgs e)
        {

        }
    }
}
