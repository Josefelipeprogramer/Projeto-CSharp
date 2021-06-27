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
    public class ProfessorConexao
    {
        public static string conn;
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static string sql;

        public ProfessorConexao()
        {
            conn = ConfigurationManager.AppSettings["Bancoprojeto"];
        }
        public void InsereDados(Professor professor)
        {
            conexao = new MySqlConnection(conn);
            sql = "insert into projeto (cpf_prof, nome_prof,sexo_prof,idade_prof,nome_disc, salario_prof)values (?pCpf,?pNome,?pSexo,?pIdade,?pDisciplina,?pSalario)";
            comando = new MySqlCommand(sql, conexao);

            try
            {
                comando.Parameters.AddWithValue("?pCpf", professor.cpf_prof);
                comando.Parameters.AddWithValue("?pNome", professor.nome_prof);
                comando.Parameters.AddWithValue("?pSexo", professor.idade_prof);
                comando.Parameters.AddWithValue("?pIdade", professor.idade_prof);
                comando.Parameters.AddWithValue("?pDisciplina", professor.nome_disc);
                comando.Parameters.AddWithValue("?pSalario", professor.salario_prof);

                conexao.Open();
                int quant = comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
             //Método atualizar professor

        public void UpdateDadosAluno(Professor professor)
        {
            conexao = new MySqlConnection(conn);
            sql = ("update aluno set aluno = ?pAluno where  cpf_prof= ?pCpf");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", professor.cpf_prof);
                comando.Parameters.AddWithValue("?pNome", professor.nome_prof);
                comando.Parameters.AddWithValue("?pSexo", professor.idade_prof);
                comando.Parameters.AddWithValue("?pIdade", professor.idade_prof);
                comando.Parameters.AddWithValue("?pDisciplina", professor.nome_disc);
                comando.Parameters.AddWithValue("?pSalario", professor.salario_prof);
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

        //Metod para Buscar Aluno
        public void SelectDadosAluno(Professor professor)
        {
            conexao = new MySqlConnection(conn);
            sql = ("select * from genero where (cpf_prof) values (?pCpf");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", professor.cpf_prof);
                comando.Parameters.AddWithValue("?pNome", professor.nome_prof);
                comando.Parameters.AddWithValue("?pSexo", professor.idade_prof);
                comando.Parameters.AddWithValue("?pIdade", professor.idade_prof);
                comando.Parameters.AddWithValue("?pDisciplina", professor.nome_disc);
                comando.Parameters.AddWithValue("?pSalario", professor.salario_prof);
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

        //Metodo para Listar Aluno
        public MySqlDataReader listAllGenero()
        {
            conexao = new MySqlConnection(conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            sql = ("select * from professor");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                da.SelectCommand = comando;
                da.Fill(dt);
                conexao.Open();
                MySqlDataReader leitor = comando.ExecuteReader();
                i = comando.ExecuteNonQuery();
                return leitor;
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


        //Metodo para Deletar Aluno
        public void DeleteDadosGenero(Professor professor)
        {
            conexao = new MySqlConnection(conn);
            sql = ("delete * from aluno where Cpf_prof = ?pCpf");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", professor.cpf_prof);
                comando.Parameters.AddWithValue("?pNome", professor.nome_prof);
                comando.Parameters.AddWithValue("?pSexo", professor.idade_prof);
                comando.Parameters.AddWithValue("?pIdade", professor.idade_prof);
                comando.Parameters.AddWithValue("?pDisciplina", professor.nome_disc);
                comando.Parameters.AddWithValue("?pSalario", professor.salario_prof);
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

    
