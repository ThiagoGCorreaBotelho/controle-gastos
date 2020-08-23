using ControleGasto.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ControleGasto.Controllers
{
    public class LancamentoController
    {
        public int Inserir(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração de conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Paramentros

                comandoSqlServer.CommandText = $"Insert Into Lancamento ([Tipo], [Descricao], [Valor], [Mes], [AnoId], [Data]) Values (@Tipo, @Descricao, @Valor, @Mes, @AnoId, @Data)";   // Comando de insert
                comandoSqlServer.Parameters.Add("Tipo", SqlDbType.VarChar).Value = objeto.Tipo;
                comandoSqlServer.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objeto.Descricao;
                comandoSqlServer.Parameters.Add("Valor", SqlDbType.Decimal).Value = objeto.Valor;
                comandoSqlServer.Parameters.Add("Mes", SqlDbType.VarChar).Value = objeto.Mes;
                comandoSqlServer.Parameters.Add("AnoId", SqlDbType.Int).Value = objeto.AnoId;
                comandoSqlServer.Parameters.Add("Data", SqlDbType.DateTime).Value = objeto.Data;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                #endregion

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<Lancamento> Buscar(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração de conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Parametros

                comandoSqlServer.CommandText = $"Select * From Lancamento Where Data = @Data";   // Comando de select
                comandoSqlServer.Parameters.Add("Data", SqlDbType.DateTime).Value = objeto.Data;
                comandoSqlServer.Connection = con; // Finaliza o comando.


                #endregion

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na grid
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento retorno = new Lancamento();
                        retorno.LancamentoId = Convert.ToInt32(dr["LancamentoId"]);
                        retorno.Tipo = Convert.ToString(dr["Tipo"]);
                        retorno.Descricao = Convert.ToString(dr["Descricao"]);
                        retorno.Valor = Convert.ToDecimal(dr["Valor"]);
                        retorno.Mes = Convert.ToString(dr["Mes"]);
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Data = Convert.ToDateTime(dr["Data"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public List<Lancamento> BuscarTipo(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração de conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Parametros

                comandoSqlServer.CommandText = $"Select * From Lancamento Where Tipo = @Tipo";   // Comando de select
                comandoSqlServer.Parameters.Add("Tipo", SqlDbType.VarChar).Value = objeto.Tipo;
                comandoSqlServer.Connection = con; // Finaliza o comando.


                #endregion

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na grid
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento retorno = new Lancamento();
                        retorno.LancamentoId = Convert.ToInt32(dr["LancamentoId"]);
                        retorno.Tipo = Convert.ToString(dr["Tipo"]);
                        retorno.Descricao = Convert.ToString(dr["Descricao"]);
                        retorno.Valor = Convert.ToDecimal(dr["Valor"]);
                        retorno.Mes = Convert.ToString(dr["Mes"]);
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Data = Convert.ToDateTime(dr["Data"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public List<Lancamento> BuscarDataTipoEntrada(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração de conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Parametros

                try
                {


                    comandoSqlServer.CommandText = $"Select * From Lancamento Where Data = @Data and Tipo = @Tipo";   // Comando de select
                    comandoSqlServer.Parameters.Add("Data", SqlDbType.DateTime).Value = objeto.Data;
                    comandoSqlServer.Parameters.Add("Tipo", SqlDbType.VarChar).Value = "Entrada";
                    comandoSqlServer.Connection = con; // Finaliza o comando.
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro no método (Método: BuscarDataTipoEntrada || Controller: Lacanmento) Erro: {ex}");
                }

                #endregion

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na grid
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento retorno = new Lancamento();
                        retorno.LancamentoId = Convert.ToInt32(dr["LancamentoId"]);
                        retorno.Tipo = Convert.ToString(dr["Tipo"]);
                        retorno.Descricao = Convert.ToString(dr["Descricao"]);
                        retorno.Valor = Convert.ToDecimal(dr["Valor"]);
                        retorno.Mes = Convert.ToString(dr["Mes"]);
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Data = Convert.ToDateTime(dr["Data"]);
                        lista.Add(retorno);
                    }

                }

                return lista;


            }
        }

        public List<Lancamento> BuscarDataTipoSaida(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração de conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Parametros

                comandoSqlServer.CommandText = $"Select * From Lancamento Where Data = @Data and Tipo = @Tipo";   // Comando de select
                comandoSqlServer.Parameters.Add("Data", SqlDbType.DateTime).Value = objeto.Data;
                comandoSqlServer.Parameters.Add("Tipo", SqlDbType.VarChar).Value = "Saída";
                comandoSqlServer.Connection = con; // Finaliza o comando.


                #endregion

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na grid
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento retorno = new Lancamento();
                        retorno.LancamentoId = Convert.ToInt32(dr["LancamentoId"]);
                        retorno.Tipo = Convert.ToString(dr["Tipo"]);
                        retorno.Descricao = Convert.ToString(dr["Descricao"]);
                        retorno.Valor = Convert.ToDecimal(dr["Valor"]);
                        retorno.Mes = Convert.ToString(dr["Mes"]);
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Data = Convert.ToDateTime(dr["Data"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public List<Lancamento> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Select * From Lancamento";   // Comando de select
                comandoSqlServer.Connection = con; // Finaliza o comando.

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = comandoSqlServer.ExecuteReader(); // Carrega as informações no data reader

                // verifica se tem linha e adiciona na linha
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento retorno = new Lancamento();
                        retorno.LancamentoId = Convert.ToInt32(dr["LancamentoId"]);
                        retorno.Tipo = Convert.ToString(dr["Tipo"]);
                        retorno.Descricao = Convert.ToString(dr["Descricao"]);
                        retorno.Valor = Convert.ToDecimal(dr["Valor"]);
                        retorno.Mes = Convert.ToString(dr["Mes"]);
                        retorno.AnoId = Convert.ToInt32(dr["AnoId"]);
                        retorno.Data = Convert.ToDateTime(dr["Data"]);
                        lista.Add(retorno);
                    }

                }

                return lista;

            }
        }

        public int Alterar(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração conexao

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.

                #endregion

                #region Parametros

                comandoSqlServer.CommandText = $"Update Lancamento Set Tipo = @Tipo, Descricao = @Descricao, Valor = @Valor, Mes = @Mes, AnoId = @AnoId, Data = @Data Where LancamentoId = @LancamentoId";   // Comando de alter
                comandoSqlServer.Parameters.Add("LancamentoId", SqlDbType.Int).Value = objeto.LancamentoId;
                comandoSqlServer.Parameters.Add("Tipo", SqlDbType.VarChar).Value = objeto.Tipo;
                comandoSqlServer.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objeto.Descricao;
                comandoSqlServer.Parameters.Add("Valor", SqlDbType.Decimal).Value = objeto.Valor;
                comandoSqlServer.Parameters.Add("Mes", SqlDbType.VarChar).Value = objeto.Mes;
                comandoSqlServer.Parameters.Add("AnoId", SqlDbType.Int).Value = objeto.AnoId;
                comandoSqlServer.Parameters.Add("Data", SqlDbType.DateTime).Value = objeto.Data;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                #endregion

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }

        public int Excluir(Lancamento objeto)
        {
            using (SqlConnection con = new SqlConnection())
            {

                #region Configuração Conexão

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand comandoSqlServer = new SqlCommand();
                comandoSqlServer.CommandType = CommandType.Text; // Recebe o tipo de comando em texto.
                con.Open(); // Abre a conexão.
                comandoSqlServer.CommandText = $"Delete From Lancamento  Where LancamentoId = @LancamentoId";   // Comando de delete
                comandoSqlServer.Parameters.Add("LancamentoId", SqlDbType.Int).Value = objeto.LancamentoId;
                comandoSqlServer.Connection = con; // Finaliza o comando.

                #endregion

                int qtd = comandoSqlServer.ExecuteNonQuery();
                return qtd;
            }
        }
    }
}
