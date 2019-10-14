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
    public partial class ControlsForms : Form
    {
        public ControlsForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }
        void Dispose(Principale_Form fr)
        {
            fr.Dispose();
            //this.Dispose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Dispose(new Principale_Form());
            Principale_Form fr = new Principale_Form();

            //fr.Dispose();
            //fr = new Principale_Form();
            
            
        }
    }
}
