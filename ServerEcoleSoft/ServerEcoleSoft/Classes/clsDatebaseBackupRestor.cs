using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEcoleSoft.Classes
{
    class clsDatebaseBackupRestor
    {
        private static string backupPath = "";

        public String getBackupPath(RadioButton rb, TextBox txt)
        {
            if (rb.Checked == true)
            {
                //backupPath = @"C:\BackupEcole";
                backupPath = ClassConstantes.Table.CheminBackup;
                try
                {
                    if (Directory.Exists(backupPath))
                    {
                        return backupPath;
                    }
                    DirectoryInfo di = Directory.CreateDirectory(backupPath);
                    backupPath = di.FullName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                backupPath = txt.Text;
            }
            return backupPath;
        }//Pour le selectionner un Chemin d
        public String getBackupPath()
        {

            //backupPath = @"C:\BackupEcole";
            backupPath = ClassConstantes.Table.CheminBackup;
            try
                {
                    if (Directory.Exists(backupPath))
                    {
                        return backupPath;
                    }
                    DirectoryInfo di = Directory.CreateDirectory(backupPath);
                    backupPath = di.FullName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }            
            
               return backupPath;
        }//Pour le selectionner un Chemin d
    }
}
