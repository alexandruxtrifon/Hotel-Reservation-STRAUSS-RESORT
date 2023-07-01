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
    public partial class RaportTop10Luni : Form
    {
        public RaportTop10Luni()
        {
            InitializeComponent();
        }

        private void RaportTop10Luni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet12.Top10Luni' table. You can move, or remove it, as needed.
            this.top10LuniTableAdapter.Fill(this.dataSet12.Top10Luni);
            // TODO: This line of code loads data into the 'dataSet11.Top10Luni' table. You can move, or remove it, as needed.
            this.top10LuniTableAdapter.Fill(this.dataSet11.Top10Luni);
            // TODO: This line of code loads data into the 'dataSet1.Top10Luni' table. You can move, or remove it, as needed.
            this.top10LuniTableAdapter.Fill(this.dataSet1.Top10Luni);

            this.reportViewer1.RefreshReport();
        }
    }
}
