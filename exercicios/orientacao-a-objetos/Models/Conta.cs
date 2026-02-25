using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_a_objetos.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + Saldo);
        }
    }
}