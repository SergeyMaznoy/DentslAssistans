using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMasterLoad(object sender, EventArgs e)
        {

        }

        private void MonthCalendarDateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Check", "Check");
        }

        private void ButMatClick(object sender, EventArgs e)
        {
        }
    }
}
