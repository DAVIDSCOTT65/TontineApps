using ServerEcoleSoft.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEcoleSoft.Formulaires
{
    public partial class FormSauvegarde : Form
    {
        public FormSauvegarde()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        clsDatebaseBackupRestor bd = new clsDatebaseBackupRestor();
        connexion ap = new connexion();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            try
            {
                ap.connect();
                con = new SqlConnection(ap.chemin);
                string database = con.Database.ToString();

                if (bd.getBackupPath(radioButton3, personalizePath) == string.Empty)
                {
                    MessageBox.Show("Veuillez selectionner d'abord un emplacement s.v.p.!");
                }
                else
                {

                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + bd.getBackupPath(radioButton3, personalizePath) + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FormSauvegarde_Load(object sender, EventArgs e)
        {
            try
            {
                defaultPath.Text = bd.getBackupPath(radioButton3, personalizePath);
            }
            catch (Exception)
            { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btnParcourir.Enabled = false;
            btnSauvegarde.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            btnSauvegarde.Enabled = false;
            btnParcourir.Enabled = true;
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    personalizePath.Text = dlg.SelectedPath;
                    btnSauvegarde.Enabled = true;
                }
            }
            catch (Exception)
            { }
        }
    }
}
