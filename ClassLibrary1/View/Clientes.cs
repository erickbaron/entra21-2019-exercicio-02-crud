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



        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
            MessageBox.Show("Cadastro apagado");
        }

        private void Inserir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCPF.Text;
            cliente.Rg = mtbRG.Text;
            cliente.DataNascimento =dtpDataNascimento.Value;

            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Inserir(cliente);
            MessageBox.Show("Cadastrado");
        }

        private void Alterar()
        {

        }

        private void AtualizarTabela()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            string busca = txtBusca.Text;
            List<Cliente> clientes = repositorio.ObterTodos(busca);
            dgvClientes.RowCount = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cliente = clientes[i];
                dgvClientes.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Rg,
                    cliente.DataNascimento
                });
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mtbCPF.Clear();
            mtbRG.Clear();
            dtpDataNascimento.Value = DateTime.Now;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
