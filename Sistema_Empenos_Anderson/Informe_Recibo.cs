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
            // TODO: esta línea de código carga datos en la tabla 'Data_Recibo.SP_Informe_Recibo_Detalle' Puede moverla o quitarla según sea necesario.
            this.SP_Informe_Recibo_DetalleTableAdapter.Fill(this.Data_Recibo.SP_Informe_Recibo_Detalle, Articulos.codigo);

            this.reportViewer1.RefreshReport();
        }
    }
}
