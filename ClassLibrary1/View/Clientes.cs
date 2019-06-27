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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
        }


        private void Inserir()
        {
            ContaPagar cliente = new ContaPagar();
            cliente.Nome = txtNome.Text;
            cliente.Valor = Convert.ToDecimal(mtbValor.Text);
            cliente.Tipo = cbTipo.SelectedItem.ToString();
            cliente.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);

            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Inserir(cliente);
            MessageBox.Show("Cadastrado");
        }


    }
}
