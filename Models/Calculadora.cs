using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calculadora_PSP01.Models
{
    public class Calculadora
    {
        private double Numero1;
        private double Numero2;

        public Calculadora()
        {

        }

        public double GetNumero1()
        {
            return Numero1;
        }

        public void SetNumero1(double numero1)
        {
            Numero1 = numero1;
        }

        public double GetNumero2()
        {
            return Numero2;
        }

        public void SetNumero2(double numero2)
        {
            Numero2 = numero2;
        }

        public double Suma()
        {
            return Numero1 + Numero2;
        }

        public double Resta()
        {
            return Numero1 - Numero2;
        }

        public double Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public decimal Division()
        {
            return Convert.ToDecimal(Numero1) / Convert.ToDecimal(Numero2);
        }
    }
}