using System;
using System.Globalization;

namespace Project
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }
        //Contrutor com 2 argumentos
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }
        // this = usado para pegar valor do construtor de 2 argumentos

        public void Deposito(double qtde)
        {
            Saldo += qtde;
        }
        public void Saque(double qtde)
        {
            Saldo -= qtde + 5.0;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);


        }

        
    }
}
