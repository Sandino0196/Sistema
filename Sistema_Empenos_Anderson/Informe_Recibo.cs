using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Informe_Recibo : Form
    {
        public Informe_Recibo()
        {
            InitializeComponent();
        }

        private void Informe_Recibo_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
