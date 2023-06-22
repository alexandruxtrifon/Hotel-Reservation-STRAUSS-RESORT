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
    public partial class FormRaportUtilizatori : Form
    {
        public FormRaportUtilizatori()
        {
            InitializeComponent();
        }

        private void FormRaportUtilizatori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Utilizator' table. You can move, or remove it, as needed.
            this.utilizatorTableAdapter.Fill(this.dataSet1.Utilizator);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
