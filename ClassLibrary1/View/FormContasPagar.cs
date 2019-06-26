using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using Repository;

namespace View
{
    public partial class FormContasPagar : Form
    {
        public FormContasPagar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void Inserir()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();
            contaPagar.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);

            ContasPagarRepositorio repositorio = new ContasPagarRepositorio();
            repositorio.Inserir(contaPagar);
            MessageBox.Show("Cadastrado");
        }
    }
}
