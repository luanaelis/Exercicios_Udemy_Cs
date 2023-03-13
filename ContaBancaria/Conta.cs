using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancariaClasses
{
    internal class Conta
    {
        private string _nome;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta (int numeroConta, string nome) 
        {
            NumeroConta = numeroConta;
            _nome = nome;
        }

        public Conta(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            Saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double RealizarDeposito(double deposito)
        {
            return Saldo += deposito;
        }

        public double RealizarSaque(double saque)
        {
            return Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + _nome
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
