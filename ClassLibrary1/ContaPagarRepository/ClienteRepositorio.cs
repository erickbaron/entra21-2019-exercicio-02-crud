using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=T:\Documentos\BancoDados.mdf;
Integrated Security=True;Connect Timeout=30";

        public void Inserir(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes
(nome, cpf, rg, data_nascimento)
VALUES (@NOME, @CPF, @RG, @DATA_NASCIMENTO)";

            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Cliente cliente)
        {
             SqlConnection conexao = new SqlConnection();
        conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
        comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET
                                    nome = @NOME,
                                    cpf = @CPF,
                                    rg = @RG,
                                    data_nascimento = @DATA_NASCIMENTO
                                    WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Cliente ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            Cliente cliente = new Cliente();
            DataRow linha = tabela.Rows[0];
            cliente.Id = Convert.ToInt32(linha["id"]);
            cliente.Nome = linha["nome"].ToString();
            cliente.Cpf = linha["cpf"].ToString();
            cliente.Rg = linha["rg"].ToString();
            cliente.DataNascimento = Convert.ToDateTime(linha["data_nascimento"]);

            return cliente;

        }

        public List<Cliente> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM clientes
                                    WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<Cliente> clientes = new List<Cliente>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(linha["id"]);
                cliente.Nome = linha["nome"].ToString();
                cliente.Cpf = linha["cpf"].ToString();
                cliente.Rg = linha["rg"].ToString();
                cliente.DataNascimento= Convert.ToDateTime(linha["data_nascimento"]);

                clientes.Add(cliente);
            }
            return clientes;
        }


    }
}
