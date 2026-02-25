using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_a_objetos.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno()
        {
            
        }

        public Aluno(string nome) : base (nome)
        {
            
        }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}