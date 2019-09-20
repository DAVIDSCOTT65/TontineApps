using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TontineUtilities;
using UIProject.UserControls;

namespace UIProject.Forms
{
    public partial class Principale_Form : Form
    {
        int panelWidth;
        bool isColapsed;
        UC_Home home = new UC_Home();
        public delegate void SendId(Principale_Form form1);
        public Principale_Form()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;
            isColapsed = false;
        }
        public void ChargerUser(UserControl userc)
        {
            try
            {
                userc.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(userc);

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
       
        private void Principale_Form_Load(object sender, EventArgs e)
        {
            
            var form = new ConnectionUser();
            form.ShowDialog();
            ShowHome(home);
            //SendId send = new SendId(form.FundForm1);
            lblUser.Text = UserSession.GetInstance().UserName.ToString();
            lblRole.Text = UserSession.GetInstance().Fonction.ToString();
        }
        public void FundDataLogin(string data)
        {
            lblUser.Text = data;
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
            UC_Cotisation uc = new UC_Cotisation();
            if (isColapsed)
            {
               
                panelLeft.Width = panelLeft.Width + 10;
                

               

                if (panelLeft.Width>=panelWidth )
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
            UC_Home user = new UC_Home();
            MoveSidePanel(btnHome);
            ChargerUser(user);
            
        }

        private void btnMembre_Click(object sender, EventArgs e)
        {
            UC_Member fr = new UC_Member();
            MoveSidePanel(btnMembre);
            ChargerUser(fr);
        }

        private void btnContrib_Click(object sender, EventArgs e)
        {
            UC_Cotisation fr = new UC_Cotisation();
            MoveSidePanel(btnContrib);
            ChargerUser(fr); 
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            UC_Remboursement fr = new UC_Remboursement();
            MoveSidePanel(btnRefund);
            ChargerUser(fr);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            UC_Round fr = new UC_Round();
            MoveSidePanel(btnRound);
            ChargerUser(fr);
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnParameters);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd/MM/yyyy HH:MM:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void ShowHome(object formF)
        {
            UC_Home home = formF as UC_Home;
            home.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(home);
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ConnectionUser cu = new ConnectionUser();
            //cu.ShowDialog();
        }
    }
}
