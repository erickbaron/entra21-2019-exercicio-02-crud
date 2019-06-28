using Model;
using Repository;
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
    public partial class ContaReceberForm : Form
    {
        public ContaReceberForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvContasReceber.CurrentRow.Cells[0].Value);
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
            MessageBox.Show("Cadastro Apagado");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void Inserir()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecebido.Text);
            contaReceber.DataRecebimento = dtpDataVencimento.Value;
            contaReceber.Recebido = ckbRecebido.Checked;

            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Inserir(contaReceber);
            MessageBox.Show("Cadastrado");
        }

        private void Alterar()
        {

        }

        private void Editar()
        {

        }

        private void AtualizarTabela()
        {
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            string busca = txtBusca.Text;
            List<ContaReceber> contasReceber = repositorio.ObterTodos(busca);
            dgvContasReceber.RowCount = 0;
            for (int i = 0; i < contasReceber.Count; i++)
            {
                ContaReceber contaReceber = contasReceber[i];
                dgvContasReceber.Rows.Add(new object[]
                {
                    contaReceber.Id,
                    contaReceber.Nome,
                    contaReceber.Valor,
                    contaReceber.ValorRecebido,
                    contaReceber.DataRecebimento,
                    contaReceber.Recebido
                });
            }
        }

        private void ContaReceberForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
