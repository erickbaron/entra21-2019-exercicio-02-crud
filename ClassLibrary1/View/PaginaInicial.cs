using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnContaPagar_Click(object sender, EventArgs e)
        {
            FormContasPagar form = new FormContasPagar();
            form.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Visible = true;
        }
    }
}
