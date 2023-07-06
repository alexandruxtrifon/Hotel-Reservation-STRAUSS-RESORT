using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class RaportPerformanta : Form
    {
        public RaportPerformanta()
        {
            InitializeComponent();
        }


        private void RaportPerformanta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Performanta' table. You can move, or remove it, as needed.
            this.performantaTableAdapter.Fill(this.dataSet1.Performanta);

            this.reportViewer1.RefreshReport();
        }
    }
}
