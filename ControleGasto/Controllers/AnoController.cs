using ControleGasto.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ControleGasto.Controllers
{
    public class AnoController
    {
        public int Inserir(Anos objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Insert Into Ano ([Ano]) Values (@Ano)";   // Comando de insert
                comandoSqlServer.Parameters.Add("Ano", SqlDbType.Int).Value = objeto.Ano;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<Anos> Buscar (Anos objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Select * From Ano Where Ano = @Ano";   // Comando de select
                comandoSqlServer.Parameters.Add("Ano", SqlDbType.Int).Value = objeto.Ano;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na grid
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Anos retorno = new Anos();
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Ano = Convert.ToInt32(dr["Ano"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public List<Anos> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Select * From Ano";   // Comando de select
                comandoSqlServer.Connection = con; // Finaliza o comando.

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na linha
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Anos retorno = new Anos();
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Ano = Convert.ToInt32(dr["Ano"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public int Alterar(Anos objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Update Ano Set Ano = @Ano Where AnoId = @AnoId";   // Comando de alter
                comandoSqlServer.Parameters.Add("Ano", SqlDbType.Int).Value = objeto.Ano;
                comandoSqlServer.Parameters.Add("AnoId", SqlDbType.Int).Value = objeto.AnoId;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }

        public int Excluir(Anos objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Delete From Ano  Where AnoId = @AnoId";   // Comando de delete
                comandoSqlServer.Parameters.Add("AnoId", SqlDbType.Int).Value = objeto.AnoId;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }

    }
}
