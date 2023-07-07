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
    public partial class RaportVenituri : Form
    {
        public RaportVenituri()
        {
            InitializeComponent();
        }

        private void RaportVenituri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VenituriLuna' table. You can move, or remove it, as needed.
            this.venituriLunaTableAdapter.Fill(this.dataSet1.VenituriLuna);

            this.reportViewer1.RefreshReport();
        }
    }
}
