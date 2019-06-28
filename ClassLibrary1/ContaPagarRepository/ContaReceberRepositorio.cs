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
    public class ContaReceberRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=T:\Documentos\BancoDados.mdf;
Integrated Security=True;Connect Timeout=30";

        public void Inserir(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_receber (nome, valor, valor_recebido, data_vencimento, recebido)
VALUES(@NOME, @VALOR, @VALOR_RECEBIDO, @DATA_VENCIMENTO, @RECEBIDO)";

            comando.Parameters.AddWithValue("@NOME", contaReceber.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaReceber.Valor);
            comando.Parameters.AddWithValue("@VALOR_RECEBIDO", contaReceber.ValorRecebido);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", contaReceber.DataRecebimento);
            comando.Parameters.AddWithValue("@RECEBIDO", contaReceber.Recebido);

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
            comando.CommandText = @"DELETE FROM contas_receber
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
            
        }

        public ContaReceber ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM contas_receber WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            ContaPagar contaPagar = new ContaPagar();
            DataRow linha = tabela.Rows[0];

            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = Convert.ToInt32(linha["id"]);
            contaReceber.Nome = linha["nome"].ToString();
            contaReceber.Valor = Convert.ToDecimal(linha["valor"]);
            contaReceber.ValorRecebido = Convert.ToDecimal(linha["valor_recebido"]);
            contaReceber.DataRecebimento = Convert.ToDateTime(linha["data_vencimento"]);
            contaReceber.Recebido = Convert.ToBoolean(linha["recebido"]);

            return contaReceber;
        }

        public List<ContaReceber> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_receber
                                    WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<ContaReceber> contasReceber = new List<ContaReceber>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaReceber contaReceber = new ContaReceber();
                contaReceber.Id = Convert.ToInt32(linha["id"]);
                contaReceber.Nome = linha["nome"].ToString();
                contaReceber.Valor = Convert.ToDecimal(linha["valor"]);
                contaReceber.ValorRecebido = Convert.ToDecimal(linha["valor_recebido"]);
                contaReceber.DataRecebimento = Convert.ToDateTime(linha["data_vencimento"]);
                contaReceber.Recebido = Convert.ToBoolean(linha["recebido"]);

                contasReceber.Add(contaReceber);
            }
            return contasReceber;
        }
    }
}
