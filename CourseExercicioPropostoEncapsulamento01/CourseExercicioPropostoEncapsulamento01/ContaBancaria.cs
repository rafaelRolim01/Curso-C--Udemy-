using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CourseExercicioPropostoEncapsulamento01
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito( double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo;
            Saldo -= 5.00;
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", Titular: " 
                + _titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
