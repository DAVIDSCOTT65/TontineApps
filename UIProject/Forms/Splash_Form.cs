using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIProject.Classes;

namespace UIProject.Forms
{
    public partial class Splash_Form : Form
    {
        public Splash_Form()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if (rectangleShape2.Width >= 551)
                {
                    timer1.Stop();
                    this.Hide();
                    PubCon.testFile();
                   
                    Principale_Form fr = new Principale_Form();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
