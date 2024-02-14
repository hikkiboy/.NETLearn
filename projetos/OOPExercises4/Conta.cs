using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises4
{
    internal class Conta
    {
        string Nome { get; set; }
        public double Saldo {  get; private set; }
        double DepositoInicial { get; set; }
        public int NumeroConta { get; private set; }

        public Conta()
        {

        }

        public Conta(string nome, double depositoInicial, int numeroConta)
        {
            Nome = nome;
            Saldo += depositoInicial;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public void Saque(double qntd)
        {
            Saldo -= qntd + 5.00;
        }
        public void Deposito(double qntd)
        {
            Saldo += qntd;
        }

        public override string ToString()
        {
            return "Dados da conta:\n Conta:  " + NumeroConta + " , Titular:  " + Nome + ", Saldo: " + Saldo ;
        }
    }
}
