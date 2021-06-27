using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Projeto_csharp
{
    public class Disciplina
    {
         //atributos 
        //metodos gets e sets
        public string cod_disc{get;set;}
        public string nome_disc{get;set;}
        public string desc_disc{get;set;}
        public string cpf_prof{get;set;}
        
         //construtores
        public Disciplina()
        { }
        public Disciplina(string codigo, string nome, string descricao, string professor)
        {
            this.cod_disc = codigo;
            this.nome_disc = nome;
            this.desc_disc = descricao;
            this.cpf_prof = professor;
           
        }

      
       
       
    }
}