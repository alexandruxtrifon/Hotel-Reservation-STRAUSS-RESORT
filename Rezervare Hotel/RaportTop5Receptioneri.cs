using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    public partial class RaportTop5Receptioneri : Form
    {
        public RaportTop5Receptioneri()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Top5Receptioneri' table. You can move, or remove it, as needed.
            this.top5ReceptioneriTableAdapter.Fill(this.dataSet1.Top5Receptioneri);

            this.reportViewer1.RefreshReport();
        }
    }
}
