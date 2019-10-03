using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TontineUtilities
{
    public class ClsMessages
    {
        private delegate void SetTextCallback(string text);
        //private int port;
        //private int baudRate;
        //private int timeout;
        //private GsmCommMain comm;
        private DataTable dt = new DataTable();

        public GsmCommMain comm;
        SmsSubmitPdu pdu;
        OutgoingSmsPdu[] pdus;

        public bool sendlongMsg(string num, string msg)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool Retourne = false;
            try
            {
                // Send an SMS message              

                string message = msg;
                if (msg.Length >= 140)
                {

                    double t = message.Length / 140;
                    double f = Math.Round(t);
                    int k = int.Parse(f.ToString()) + 1;
                    pdus = new OutgoingSmsPdu[k];
                    string ps = message.Substring(0, 140);
                    int dep = 0;

                    for (int i = 0; i < k; i++)
                    {
                        pdu = new SmsSubmitPdu(ps, num);
                        pdus[i] = pdu;
                        dep = dep + ps.Length;

                        if ((message.Length - dep) <= 140 && (message.Length - dep) > 2)
                        {
                            ps = message.Substring(ps.Length, message.Length - 1 - dep);
                        }
                        else if ((message.Length - dep) >= 139)
                        {
                            ps = message.Substring(dep, 140);
                        }
                    }
                    
                    if (pubCon.comm.IsOpen())comm.Open();
                    pubCon.comm.SendMessages(pdus);
                    MessageBox.Show("Message envoye avec succes !!!!");
                    Retourne = true;

                }

                // Send the same message multiple times if this is set
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message); 
                Retourne = false;
            }

            Cursor.Current = Cursors.Default;

            return Retourne;

        }

        public bool sendshortMsg(string num, string msg)
        {

            bool Envoie = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Send an SMS message
                SmsSubmitPdu pdu;
                //bool alert = chkAlert.Checked;
                bool alert = false;
                //bool unicode = chkUnicode.Checked;
                bool unicode = true;

                if (!alert && !unicode)
                {
                    // The straightforward version
                    pdu = new SmsSubmitPdu(msg, num, "");  // "" indicate SMSC No
                }
                else
                {
                    // The extended version with dcs
                    byte dcs;
                    if (!alert && unicode)
                        dcs = DataCodingScheme.NoClass_16Bit;
                    else if (alert && !unicode)
                        dcs = DataCodingScheme.Class0_7Bit;
                    else if (alert && unicode)
                        dcs = DataCodingScheme.Class0_16Bit;
                    else
                        dcs = DataCodingScheme.NoClass_7Bit; // should never occur here

                    pdu = new SmsSubmitPdu(msg, num, "", dcs);
                }

                // Send the same message multiple times if this is set
                int times = true ? int.Parse("1") : 1;

                if (pubCon.comm.IsOpen())
                    pubCon.comm.Open();
                // Send the message the specified number of times
                for (int i = 0; i < times; i++)
                {
                    pubCon.comm.SendMessage(pdu);
                    //Output(string.Format("Message {0} of {1} sent.\n", i + 1, times));
                    //Output(""); 
                    Envoie = true;
                }
                Envoie = true;


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Envoie = false;
            }

            Cursor.Current = Cursors.Default;

            return Envoie;
        }
        public void sendSMS(string num, string msg)
        {
            try
            {
                sendlongMsg(num, msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
