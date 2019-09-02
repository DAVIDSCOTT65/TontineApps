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
        public Principale_Form()
        {
            InitializeComponent();
        }

        private void Principale_Form_Load(object sender, EventArgs e)
        {
            var form = new ConnectionUser();
            form.ShowDialog();
        }
    }
}
