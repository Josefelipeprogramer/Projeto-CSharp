using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Projeto_csharp
{
    public class Notas
    {
        
        //atributos 
        //metodos gets e sets
        public string cod_nota{get;set;}
        public string freq_nota{get;set;}
        public string cod_disc{get;set;}
        public string cpf_prof{get;set;}
        public string cpf_al{get;set;}
        public string nota_n{get;set;}
      

         //construtores
        public Notas()
        { }
        public Notas(string codigo, string frequencia, string disciplina, string professor, string aluno, string nota)
        {
            this.cod_nota = nota;
            this.freq_nota = frequencia;
            this.cod_disc = disciplina;
            this.cpf_prof = professor;
            this.cpf_al = aluno;
            this.nota_n = nota;
            
        }
    }
}