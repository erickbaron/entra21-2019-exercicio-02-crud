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

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            cbTipo.SelectedIndex = -1;
            dtpDataVencimento.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                Alterar();
            }
            else
            {
                Inserir();
            }
            AtualizarTabela();
            LimparCampos();
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

        private void Alterar()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = Convert.ToInt32(lblId.Text);
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();
            contaPagar.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);

            ContasPagarRepositorio repositorio = new ContasPagarRepositorio();
            repositorio.Alterar(contaPagar);
            MessageBox.Show("Alterado");

        }

        private void AtualizarTabela()
        {
            ContasPagarRepositorio repositorio = new ContasPagarRepositorio();
            string busca = txtBusca.Text;
            List<ContaPagar> contasPagar = repositorio.ObterTodos(busca);
            dgvContasPagar.RowCount = 0;
            for (int i = 0; i < contasPagar.Count; i++)
            {
                ContaPagar contaPagar = contasPagar[i];
                dgvContasPagar.Rows.Add(new object[]
                {
                    contaPagar.Id,
                    contaPagar.Nome,
                    contaPagar.Valor,
                    contaPagar.Tipo,
                    contaPagar.DataVencimento
                });
            }
        }

        private void FormContasPagar_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvContasPagar.CurrentRow.Cells[0].Value);
            ContasPagarRepositorio repositorio = new ContasPagarRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
            MessageBox.Show("Cadastro Apagado");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            ContasPagarRepositorio repositorio = new ContasPagarRepositorio();

            int id = Convert.ToInt32(dgvContasPagar.CurrentRow.Cells[0].Value);

            ContaPagar contaPagar = repositorio.ObterPeloId(id);
            if (contaPagar != null)
            {
                txtNome.Text = contaPagar.Nome;
                mtbValor.Text = contaPagar.Valor.ToString("0000.00");
                cbTipo.SelectedItem = contaPagar.Tipo.ToString();
                dtpDataVencimento.Text = contaPagar.DataVencimento.ToString();
                lblId.Text = contaPagar.Id.ToString();
            }
        }

        private void dgvContasPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
