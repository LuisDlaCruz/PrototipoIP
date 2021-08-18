using System;
using System.Drawing;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formError : Form
    {
        public formError(Exception e)
        {
          
        }

        public formError(string e)
        {
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnErrorEntendido_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void lblError_Click(object sender, EventArgs e)
        {
        }
    }
}