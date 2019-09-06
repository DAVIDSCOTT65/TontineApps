using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            chartWeek.Series["Week"].Points.AddXY("Day1", 8000);
            chartWeek.Series["Week"].Points.AddXY("Day2", 5000);
            chartWeek.Series["Week"].Points.AddXY("Day3", 3000);
            chartWeek.Series["Week"].Points.AddXY("Day4", 1000);
            chartWeek.Series["Week"].Points.AddXY("Day5", 1000);
            chartWeek.Series["Week"].Points.AddXY("Day6", 3000);
            chartWeek.Series["Week"].Points.AddXY("Day7", 7000);
            chartWeek.Series["Week"].Points.AddXY("Day8", 4000);
        }
    }
}
