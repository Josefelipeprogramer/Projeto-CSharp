using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Projeto_csharp
{
    public class Aluno
    {
 

        //atributos 
        //metodos gets e sets
        public string cpf_al{get;set;}
        public string nome_al{get;set;}
        public string sexo_al{get;set;}
        public string idade_al{get;set;}
        public string serie_al{get;set;}
        public string turno_al{get;set;}
        public string turma_al{get;set;}

         //construtores
        public Aluno()
        { }
        public Aluno(string cpf, string nome, string sexo, string idade, string serie, string turno, string turma)
        {
            this.cpf_al = cpf;
            this.nome_al = nome;
            this.sexo_al = sexo;
            this.idade_al = idade;
            this.serie_al = serie;
            this.turno_al = turno;
            this.turma_al = turma;
        }

      
       
        
        }
    }
