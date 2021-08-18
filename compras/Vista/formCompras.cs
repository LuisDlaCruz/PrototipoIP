using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public partial class formCompras : Form
    {
        public formCompras()
        {
            InitializeComponent();
        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prototipoipDataSet.compras_detalle' Puede moverla o quitarla según sea necesario.
            this.compras_detalleTableAdapter.Fill(this.prototipoipDataSet.compras_detalle);
            // TODO: esta línea de código carga datos en la tabla 'prototipoipDataSet.compras_encabezado' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'prototipoipDataSet.compras_detalle' Puede moverla o quitarla según sea necesario.
            this.compras_detalleTableAdapter.Fill(this.prototipoipDataSet.compras_detalle);

        }
    }
}
