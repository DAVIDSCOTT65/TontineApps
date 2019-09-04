using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject.Forms
{
    public partial class Principale_Form : Form
    {
        int panelWidth;
        bool isColapsed;

        public Principale_Form()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;
            isColapsed = false;
        }

        private void Principale_Form_Load(object sender, EventArgs e)
        {
            var form = new ConnectionUser();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width>=panelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnHome);
        }

        private void btnMembre_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnMembre);
        }

        private void btnContrib_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnContrib);
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnRefund);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnRound);
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnParameters);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
