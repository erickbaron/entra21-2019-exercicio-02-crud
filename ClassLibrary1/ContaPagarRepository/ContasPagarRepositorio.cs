using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContasPagarRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

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
    }
}
