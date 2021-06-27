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
    public class AlunoConexao
    {
        public static string conn;
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static string sql;

        public AlunoConexao()
        {
            conn = ConfigurationManager.AppSettings["Bancoprojeto"];
        }
        public void InsereDados(Aluno aluno)
        {
            conexao = new MySqlConnection(conn);
            sql = "insert into aluno(cpf_al, nome_al,sexo_al,idade_al, serie_al, turno_al,turma_al) values (?pCpf,?pNome,?pSexo,?pIdade,?pSerie,?pTurno,?pTurma)";
            comando = new MySqlCommand(sql, conexao);

            try
            {
                comando.Parameters.AddWithValue("?pCpf", aluno.cpf_al);
                comando.Parameters.AddWithValue("?pNome", aluno.nome_al);
                comando.Parameters.AddWithValue("?pSexo", aluno.sexo_al);
                comando.Parameters.AddWithValue("?pIdade", aluno.idade_al);
                comando.Parameters.AddWithValue("?pSerie", aluno.serie_al);
                comando.Parameters.AddWithValue("?pTurno", aluno.turno_al);
                comando.Parameters.AddWithValue("?pTurma", aluno.turma_al);
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


        }
        //Metodo para Atualizar Aluno
        public void UpdateDadosAluno(Aluno aluno)
        {
            conexao = new MySqlConnection(conn);
            sql = ("update aluno set aluno = ?pAluno where  nome_al= ?nome_al");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", aluno.cpf_al);
                comando.Parameters.AddWithValue("?pNome", aluno.nome_al);
                comando.Parameters.AddWithValue("?pSexo", aluno.sexo_al);
                comando.Parameters.AddWithValue("?pIdade", aluno.idade_al);
                comando.Parameters.AddWithValue("?pSerie", aluno.serie_al);
                comando.Parameters.AddWithValue("?pTurno", aluno.turno_al);
                comando.Parameters.AddWithValue("?pTurma", aluno.turma_al);
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

        //Metodo para Buscar Aluno
        public void SelectDadosAluno(Aluno aluno)
        {
            conexao = new MySqlConnection(conn);
            sql = ("select * from aluno where (cpf_al) values (?pcpf_al");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", aluno.cpf_al());
                comando.Parameters.AddWithValue("?pNome", aluno.nome_al());
                comando.Parameters.AddWithValue("?pSexo", aluno.sexo_al());
                comando.Parameters.AddWithValue("?pIdade", aluno.idade_al());
                comando.Parameters.AddWithValue("?pSerie", aluno.serie_al());
                comando.Parameters.AddWithValue("?pTurno", aluno.turno_al());
                comando.Parameters.AddWithValue("?pTurma", aluno.turma_al());
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
            sql = ("select * from aluno");
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
        public void DeleteDadosGenero(Aluno aluno)
        {
            conexao = new MySqlConnection(conn);
            sql = ("delete * from aluno where Cpf = ?pcpf_al");
            comando = new MySqlCommand(sql, conexao);
            try
            {
                comando.Parameters.AddWithValue("?pCpf", aluno.getcpf_al());
                comando.Parameters.AddWithValue("?pNome", aluno.getnome_al());
                comando.Parameters.AddWithValue("?pSexo", aluno.getsexo_al());
                comando.Parameters.AddWithValue("?pIdade", aluno.getidade_al());
                comando.Parameters.AddWithValue("?pSerie", aluno.getserie_al());
                comando.Parameters.AddWithValue("?pTurno", aluno.getturno_al());
                comando.Parameters.AddWithValue("?pTurma", aluno.getturma_al());
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
