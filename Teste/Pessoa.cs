using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Teste
{
    public class Pessoa
    {
        public static double media;
        public int Idade { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public static string MaiorSalario(double a, double b) {
            media = (a + b) / 2;
            return media.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
