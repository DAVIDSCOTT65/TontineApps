using GsmComm.GsmCommunication;
using ServerEcoleSoft.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServerEcoleSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void SetTextCallback(string text);        
        private DataTable dt = new DataTable();
        SqlConnection myconn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        connexion ap = new connexion();
        clsDatebaseBackupRestor bc = new clsDatebaseBackupRestor();


        ClsMessages ms = new ClsMessages();

        public void SetData(int port, int baudRate, int timeout)
        {
            pubCon.port = port;
            pubCon.baudRate = baudRate;
            pubCon.timeout = timeout;
        }
        

        public void GetData(out int port, out int baudRate, out int timeout)
        {
            port = pubCon.port;
            baudRate = pubCon.baudRate;
            timeout = pubCon.timeout;
        }
        private bool EnterNewSettings()
        {
            int newPort;
            int newBaudRate;
            int newTimeout;

            try
            {
                newPort = int.Parse(portnumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid port number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPort.Focus();
                return false;
            }

            try
            {
                newBaudRate = int.Parse(cboBaudRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid baud rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboBaudRate.Focus();
                return false;
            }

            try
            {
                newTimeout = int.Parse(cboTimeout.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid timeout value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTimeout.Focus();
                return false;
            }

            SetData(newPort, newBaudRate, newTimeout);

            return true;
        }
        public string GetAllPorts(ComboBox combo)
        {
            //string MODEMS = "";
            string modems = "";

            try
            {
                //combo.Items.Clear();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem ");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if ((string)queryObj["Status"] == "OK")
                    {

                        combo.Items.Add(queryObj["AttachedTo"] + " - " + System.Convert.ToString(queryObj["Description"]));
                    }
                    if (combo.Items.Count > 0)
                    {
                        combo.SelectedIndex = 0;
                    }
                }

                return modems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la requette", "Erreur de" + ex.Message);
                return "";
            }

        }
        private void Output(string text)
        {

            try
            {
                txtOutput.AppendText(text);
               // Output1.AppendText(text);
            }

            catch (Exception)
            {
                MessageBox.Show("Message envoie");

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllPorts(cboPort);
            dataGridView1.DataSource=ClsGlossiaires.GetInstance().chargementMessagerie();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EnterNewSettings())
                    return;

                Cursor.Current = Cursors.WaitCursor;
                pubCon.comm = new GsmCommMain(pubCon.port, pubCon.baudRate, pubCon.timeout);
                try
                {
                    pubCon.comm.Open();
                    while (!pubCon.comm.IsConnected())
                    {
                        Cursor.Current = Cursors.Default;
                        if (MessageBox.Show(this, "No phone connected.", "Connection setup\n",
                            MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                        {
                            pubCon.comm.Close();
                            return;
                        }
                        Cursor.Current = Cursors.WaitCursor;
                    }
                    Output("Successfully connected to the phone.\n");
                    MessageBox.Show(this, "Successfully connected to the phone.", "Connection setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pubCon.comm.Close();
                    label_statut.BackColor = Color.Yellow;
                    //ControlMsg();
                    label_statut.Text = "Connecté";
                    //timer1.Start();
                    //btnconnect.Enabled = false;
                    //btndeconnect.Enabled = true;
                }
                catch (Exception ex)
                {
                    Output("ERREUR : " + ex.Message);
                    Output("");
                    MessageBox.Show(this, "Connection error: " + ex.Message, "Connection setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch { }
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPort.Text == "19")
            {
                portnumber.Text = "19";
            }
            else
            {
                portnumber.Text = cboPort.Text.Substring(3, 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

            dataGridView1.DataSource = ClsGlossiaires.GetInstance().chargementMessagerie();
            ClsGlossiaires.GetInstance().SendMessagePaiement();
                     
            }catch(Exception ex)
            {

            }
                  
        }

        private void demarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    ap.connect();
            //    myconn = new SqlConnection(ap.chemin);
            //    string database = myconn.Database.ToString();

            //    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + bc.getBackupPath() + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

            //    using (SqlCommand command = new SqlCommand(cmd, myconn))
            //    {
            //        if (myconn.State != ConnectionState.Open)
            //        {
            //            myconn.Open();
            //        }
            //        command.ExecuteNonQuery();
            //        myconn.Close();
            //        //XtraMessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
            //    }

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }

        private void arreterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
