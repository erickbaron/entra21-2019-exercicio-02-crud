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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
            MessageBox.Show("Cadastro apagado");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
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
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf =mtbCPF.Text;
            cliente.Rg = mtbRG.Text;
            cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);

            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Alterar(cliente);
            MessageBox.Show("Alterado");
        }

        private void Editar()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

            Cliente cliente = repositorio.ObterPeloId(id);
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                mtbCPF.Text = cliente.Cpf;
                mtbRG.Text = cliente.Rg;
                dtpDataNascimento.Text = cliente.DataNascimento.ToString();
                lblId.Text = cliente.Id.ToString();
            }
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
            lblId.Text = "";
            txtNome.Clear();
            mtbCPF.Clear();
            mtbRG.Clear();
            dtpDataNascimento.Value = DateTime.Now;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTabela();
            }    
        }
    }
}
