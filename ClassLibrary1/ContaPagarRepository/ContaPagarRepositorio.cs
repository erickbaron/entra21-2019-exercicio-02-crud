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
    public class ContaPagarRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=T:\Documentos\BancoDados.mdf;
Integrated Security=True;Connect Timeout=30";

        public void Inserir(ContaPagar contaPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_pagar
(nome, valor, tipo, data_vencimento)
VALUES (@NOME, @VALOR, @TIPO, @DATA_VENCIMENTO)";

            comando.Parameters.AddWithValue("@NOME", contaPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contaPagar.Tipo);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", contaPagar.DataVencimento);
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
            comando.CommandText = @"DELETE FROM contas_pagar WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(ContaPagar contaPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE contas_pagar SET
                                    nome = @NOME,
                                    valor = @VALOR,
                                    tipo = @TIPO,
                                    data_vencimento = @DATA_VENCIMENTO
                                    WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", contaPagar.Id);
            comando.Parameters.AddWithValue("@NOME", contaPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contaPagar.Tipo);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", contaPagar.DataVencimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public ContaPagar ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM contas_pagar WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            ContaPagar contaPagar = new ContaPagar();
            DataRow linha = tabela.Rows[0];
            contaPagar.Id = Convert.ToInt32(linha["id"]);
            contaPagar.Nome = linha["nome"].ToString();
            contaPagar.Valor = Convert.ToDecimal(linha["valor"]);
            contaPagar.Tipo = linha["tipo"].ToString();
            contaPagar.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);

            return contaPagar;

        }

        public List<ContaPagar> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_pagar
                                    WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.Add("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<ContaPagar> contasPagar = new List<ContaPagar>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaPagar contaPagar = new ContaPagar();
                contaPagar.Id = Convert.ToInt32(linha["id"]);
                contaPagar.Nome = linha["nome"].ToString();
                contaPagar.Valor = Convert.ToDecimal(linha["valor"]);
                contaPagar.Tipo = linha["tipo"].ToString();
                contaPagar.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);

                contasPagar.Add(contaPagar);
            }
            return contasPagar;
        }
    }
}
