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

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Reactor1_Click(object sender, EventArgs e)
        {

        }

        private async void ActivateButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alertSound);
            alertPlayer.Play();
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            ReactorStableLabel.BackColor= Color.White;
            ReactorStableLabel.Text = "Meltdown Hapepening";
            ReactorStableLabel.ForeColor = Color.Red;

            Thread.Sleep(1000);

            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            ReactorStableLabel.BackColor = Color.Red;
            ReactorStableLabel.ForeColor = Color.Yellow;



            Refresh();
            Thread.Sleep(1000);

            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            ReactorStableLabel.BackColor = Color.White;
            ReactorStableLabel.ForeColor = Color.Red;


            Refresh();
            Thread.Sleep(1000);

            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            ReactorStableLabel.BackColor = Color.Red;
            ReactorStableLabel.ForeColor = Color.Yellow;

        }
    }
}
