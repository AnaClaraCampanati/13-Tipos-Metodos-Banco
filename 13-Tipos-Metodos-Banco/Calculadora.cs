using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Tipos_Metodos_Banco
{
    internal class Calculadora
    {
        public static double Sacar(double saldo, double saque)
        {
            double Sacar = saldo - saque;
            return Sacar;
        }
        public static double Investir(double saldoAtual, double investimento)
        {
            double Investir = saldoAtual - investimento;
            return Investir;

        }
    }
}
