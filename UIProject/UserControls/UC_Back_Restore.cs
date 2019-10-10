using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSingleConnection;
using TontineUtilities;
using System.Data.SqlClient;

namespace UIProject.UserControls
{
    public partial class UC_Back_Restore : UserControl
    {
        DatabaseBackupOrRestor bd = new DatabaseBackupOrRestor();
        SqlConnection con = new SqlConnection();
        public UC_Back_Restore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                //con = new SqlConnection(ap.chemin);
                string database = ImplementeConnexion.Instance.Conn.Database.ToString(); 

                if (bd.getBackupPath(radioButton3, personalizePath) == string.Empty)
                {
                    MessageBox.Show("Veuillez selectionner d'abord un emplacement s.v.p.!");
                }
                else
                {

                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + bd.getBackupPath(radioButton3, personalizePath) + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, (SqlConnection)ImplementeConnexion.Instance.Conn))
                    {
                        if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                            ImplementeConnexion.Instance.Conn.Open();

                        command.ExecuteNonQuery();
                        ImplementeConnexion.Instance.Conn.Close();

                        MessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

        private void UC_Back_Restore_Load(object sender, EventArgs e)
        {
            try
            {
                defaultPath.Text = bd.getBackupPath(radioButton3, personalizePath);
            }
            catch (Exception)
            { }
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dbPath.Text = dlg.FileName;
                btnreset.Enabled = true;
            }
            btnreset.Enabled = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            
            string database = ImplementeConnexion.Instance.Conn.Database.ToString();
           
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, (SqlConnection)ImplementeConnexion.Instance.Conn);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + dbPath.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, (SqlConnection)ImplementeConnexion.Instance.Conn);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, (SqlConnection)ImplementeConnexion.Instance.Conn);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Database restoration done successefully", "Confirmation de restauration");
                //con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur de " + exc);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }
    }
}
