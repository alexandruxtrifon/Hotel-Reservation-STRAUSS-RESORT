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
    public partial class FormRaportCamereOcupate : Form
    {


        public FormRaportCamereOcupate()
        {
            InitializeComponent();
        }

        private void FormRaportCamereOcupate_Load(object sender, EventArgs e)
        {
            loaddate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loaddate();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loaddate();
        }

        private void loaddate()
        {
            DateTime selectedStartDate = dateTimePicker1.Value;
            DateTime selectedEndDate = dateTimePicker2.Value;

            this.rezervariDupaDataTableAdapter.Dispose();
            this.rezervariDupaDataTableAdapter.Fill(this.dataSet1.RezervariDupaData, selectedStartDate, selectedEndDate);
            this.reportViewer1.RefreshReport();
        }
    }
}
