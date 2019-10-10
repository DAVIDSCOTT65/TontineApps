using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentLib;
using UIProject.Forms;

namespace UIProject.UserControls
{
    public partial class UC_Agent : UserControl
    {
        public UC_Agent()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dgInscit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Agent_Load(object sender, EventArgs e)
        {
            RefreshData(new Agent());
        }
        void RefreshData(IAgent ag)
        {
            dgAgent.DataSource = ag.AllAgents();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmAgent fr = new FrmAgent();

            fr.ShowDialog();
        }
    }
}
