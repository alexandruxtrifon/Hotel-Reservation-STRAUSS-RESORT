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
    public partial class RaportCamera : Form
    {
        public RaportCamera()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Nr_Cam' table. You can move, or remove it, as needed.
            this.nr_CamTableAdapter.Fill(this.dataSet1.Nr_Cam);
            // TODO: This line of code loads data into the 'dataSet1.TipCamera' table. You can move, or remove it, as needed.
            this.tipCameraTableAdapter.Fill(this.dataSet1.TipCamera);

            this.reportViewer1.RefreshReport();
        }
    }
}
