using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Projeto_csharp
{
    public class NotasConexao
    {
        public static string conn;
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static string sql;

        public NotasConexao()
        {
            conn = ConfigurationManager.AppSettings["Bancoprojeto"];
        }
        public void InsereDados(Notas notas)
        {
            conexao = new MySqlConnection(conn);
            sql = "insert into projeto (cod_nota, freq_nota, cod_disc,cpf_prof,cpf_al, nota_n)values (?pCodigo,?pFrequencia,?pDisciplina,?pProfessor,?pAluno,?pNota)";
            comando = new MySqlCommand(sql, conexao);

            try
            {
                comando.Parameters.AddWithValue("?pCdigo", notas.cod_nota);
                comando.Parameters.AddWithValue("?pFrequencia", notas.freq_nota);
                comando.Parameters.AddWithValue("?pDiscipina", notas.cod_disc);
                comando.Parameters.AddWithValue("?pProfessor", notas.cpf_prof);
                comando.Parameters.AddWithValue("?pAluno", notas.cpf_al);
                comando.Parameters.AddWithValue("?pNota", notas.nota_n);

                conexao.Open();
                int quant = comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
            }
            finally
            {
                conexao.Close();
            }
        }
             // Método consultar
        public void SelectDadosNotas(Notas notas)
        {
            conexao = new MySqlConnection(conn);
            sql = ("select * from genero where (cod_nota) values (?pCodigo");
            comando = new MySqlCommand(sql, conexao);

            try {
                comando.Parameters.AddWithValue("?pCodigo", notas.cod_nota);
                comando.Parameters.AddWithValue("?pFrequencia", notas.freq_nota);
                comando.Parameters.AddWithValue("?pDiscipina", notas.cod_disc);
                comando.Parameters.AddWithValue("?pProfessor", notas.cpf_prof);
                comando.Parameters.AddWithValue("?pAluno", notas.cpf_al);
                comando.Parameters.AddWithValue("?pNota", notas.nota_n);

                conexao.Open();
            
            }
            catch (MySqlException e)
            {

                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }
 
       // Método deletar
        public void DeleteDadosGenero(Notas Notas)
        {
            conexao = new MySqlConnection(conn);
            sql = ("delete * from notas where cod_nota = ?pCodigo");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCodigo", notas.cod_nota);
                comando.Parameters.AddWithValue("?pFrequencia", notas.freq_nota);
                comando.Parameters.AddWithValue("?pDiscipina", notas.cod_disc);
                comando.Parameters.AddWithValue("?pProfessor", notas.cpf_prof);
                comando.Parameters.AddWithValue("?pAluno", notas.cpf_al);
                comando.Parameters.AddWithValue("?pNota", notas.nota_n);

                conexao.Open();
            }


            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
