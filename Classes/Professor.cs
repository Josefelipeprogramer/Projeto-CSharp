using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Projeto_csharp
{
    public class Professor
    {
         //atributos 
        //metodos gets e sets
        public string cpf_prof{get;set;}
        public string nome_prof{get;set;}
        public string sexo_prof{get;set;}
        public string idade_prof{get;set;}
        public string nome_disc{get;set;}
        public string salario_prof{get;set;}
        
         //construtores
        public Professor()
        { }
        public Professor(string cpf, string nome, string sexo, string idade, string disciplina, string salario)
        {
            this.cpf_prof = cpf;
            this.nome_prof = nome;
            this.sexo_prof= sexo;
            this.idade_prof= idade;
            this.nome_disc = disciplina;
            this.salario_prof= salario;
           
        }
    }
}