using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_a_objetos.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public ContaCorrente(int numeroConta, decimal SaldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = SaldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Console.WriteLine("Saque realizado com sucesso!");
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }
        
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + Saldo);
        }
    }
}