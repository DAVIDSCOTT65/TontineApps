using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIProject.Classes;

namespace UIProject.UserControls
{
    public partial class UC_Remboursement : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        int idSemaine;
        public UC_Remboursement()
        {
            InitializeComponent();
        }

        private void UC_Remboursement_Load(object sender, EventArgs e)
        {
            ChargemenCombos();
        }
        void ChargemenCombos()
        {
            dn.chargeNomsCombo(membreCombo, "Nom_Complet", "SELECT_MEMBRE_NON_REMBOURSES");
            //dn.chargeCombo(fraisCombo, "Designation", "SELECT_DESIGNATION_FRAIS");
            //dn.chargeSemainesCombo(weeksCombo, "Nom_Complet", "SELECT_MEMBRE_NON_REMBOURSES");
            //fraisCombo.SelectedIndex = 0;
        }

        private void membreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           idSemaine = dn.retourInfoRembMembre(semaineLbl, matriculeLbl, mandataireLbl,membreCombo.Text,photo);
            //dn.retreivePhoto(matriculeLbl.Text, photo);
        }
    }
}
