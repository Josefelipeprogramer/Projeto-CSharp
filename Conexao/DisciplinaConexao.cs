using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto_csharp
{
    public class DisciplinaConexao


    {
        public static string conn;
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static string sql;

        public DisciplinaConexao()
        {
            conn = ConfigurationManager.AppSettings["Bancoprojeto"];
        }
        public void InsereDados(Disciplina disciplina)
        {
            conexao = new MySqlConnection(conn);
            sql = "insert into projeto (cod_disc, nome_disc,desc_disc,cpf_prof)values (?pCodigo,?pNome,?pDescrição,?pProfessor)";
            comando = new MySqlCommand(sql, conexao);

            try
            {
                comando.Parameters.AddWithValue("?pCodigo", disciplina.cod_disc);
                comando.Parameters.AddWithValue("?pNome", disciplina.nome_disc);
                comando.Parameters.AddWithValue("?pDescrição",disciplina.desc_disc );
                comando.Parameters.AddWithValue("?pProfessor", disciplina.cpf_prof);
                

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
             // Método consultar
        public void SelectDadosNotas(Disciplina disciplina)
        {
            conexao = new MySqlConnection(conn);
            sql = ("select * from genero where (cod_disc) values (?pCodigo");
            comando = new MySqlCommand(sql, conexao);

            try
            {
                comando.Parameters.AddWithValue("?pCodigo", disciplina.cod_disc);
                comando.Parameters.AddWithValue("?pNome", disciplina.nome_disc);
                comando.Parameters.AddWithValue("?pDescrição", disciplina.desc_disc);
                comando.Parameters.AddWithValue("?pProfessor", disciplina.cpf_prof);
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
        public void DeleteDadosGenero(Disciplina disciplina)
        {
            conexao = new MySqlConnection(conn);
            sql = ("delete * from notas where cod_disc = ?pCodigo");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCodigo", disciplina.cod_disc);
                comando.Parameters.AddWithValue("?pNome", disciplina.nome_disc);
                comando.Parameters.AddWithValue("?pDescrição", disciplina.desc_disc);
                comando.Parameters.AddWithValue("?pProfessor", disciplina.cpf_prof);

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