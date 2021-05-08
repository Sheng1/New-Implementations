using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Teste;

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //var files = FindFiles(@"C:\Users\HOME\source\repos\Teste\Teste\stores");

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}


            //            string produto1 = "Computador";
            //            string produto2 = "Mesa de escritorio";

            //            byte idade = 30;
            //            int codigo = 5290;
            //            char genero = 'M';

            //            double preco1 = 2100.00;
            //            double preco2 = 650.50;
            //            double medida = 53.234567;
            //            Console.WriteLine(@$"Produtos:
            //{produto1}, cujo preço é  $ {preco1:F2}
            //{produto2}, cujo preço é $ {preco2:F2}

            //Registro: {idade} anos de idade, código {codigo} e gênero: {genero}
            //Medida com oito casas decimais: {medida:F8}
            //Arredondado (três casa decimais): {medida:F3}
            //Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");

            //--------------------------------------------------------------------------------------------

            //Console.WriteLine("Entre com seu nome completo:");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int quartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto:");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            //string[] linha = Console.ReadLine().Split(' ');
            //string lastName = linha[0];
            //int idade = int.Parse(linha[1].ToString());
            //double altura = double.Parse(linha[2].ToString(), CultureInfo.InvariantCulture);
            //Console.WriteLine(nome);
            //Console.WriteLine(quartos);
            //Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine(lastName);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
            //--------------------------------------------------------------------------------------------

            //Exercicio 1
            /*Console.WriteLine("Digite a entrada 1:");
            int entrada1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a entrada 2:");
            int entrada2 = int.Parse(Console.ReadLine());
            int soma = entrada1 + entrada2;
            Console.WriteLine("Soma = {0}",soma);*/

            //---------------------------------------------------------------------------------------------            
            /*
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = Math.Pow(raio,2) * Math.PI;
            Console.WriteLine("Area = {0}", area.ToString("F4",CultureInfo.InvariantCulture));
            */
            //----------------------------------------------------------------------------------------------

            /*
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maior = Maior(number1, number2);
            int resto = 0;
            if(maior == number1)
            {
                resto = number1 % number2;
                Console.WriteLine(resto);
                Console.WriteLine("---------------------------------------------");
                if (resto != 0)
                Console.WriteLine("Não são multiplos");
                else
                    Console.WriteLine("São multiplos");
            }
            else
            {
                resto = number2 % number1;
                Console.WriteLine(resto);
                Console.WriteLine("---------------------------------------------");
                if (resto != 0)
                    Console.WriteLine("Não são multiplos");
                else
                    Console.WriteLine("São multiplos");
            }
            */
            //-----------------------------------------------------------------------------------------------------------------
            /*
            string[] valores = Console.ReadLine().Split();
            int number1 = int.Parse(valores[0]);
            int number2 = int.Parse(valores[1]);
            int duracao = 0;
            if (number2 > number1)
                duracao = number2 - number1;
            else
                duracao = 24 - number1 + number2;

            Console.WriteLine($"O jogo durou {duracao}");*/
            /*
            string[] cdqtd = Console.ReadLine().Split();
            int caseSwitch = int.Parse(cdqtd[0]);
            int qtd = int.Parse(cdqtd[1]);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine($"{4.00 * qtd}");
                    break;
                case 2:
                    Console.WriteLine($"Total: R${4.50 * qtd}");
                    break;
                case 3:
                    Console.WriteLine($"Total: R${5.00 * qtd}");
                    break;
                case 4:
                    Console.WriteLine($"Total: R${2.00 * qtd}");
                    break;
                case 5:
                    Console.WriteLine($"Total: R${1.50 * qtd}");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }*/
            //--------------------------
            /*
            Console.WriteLine("Digite qualquer valor");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (valor>=0.00 && valor<= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor> 25.00 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor>75.00 && valor<=100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */

            //---------------------------------------------------------------------------------------------------------------------
            /*
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Esta na origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Esta no eixo y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Esta no eixo x");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro quadrante");
            }
            else if (x > 0)
            {
                Console.WriteLine("Quarto quadrante");
            }
            else if (y < 0)
            {
                Console.WriteLine("Terceiro quadrante");
            }
            else
            {
                Console.WriteLine("Segundo quadrante");
            }
            */

            /*
            double imposto = 0.00;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000)
                imposto = 0.00;
            else if (salario < 3000.01)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario < 4500.01)
            {
                imposto = (salario - 3000.01) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + (1500.00 * 0.18) + 1000 * 0.08;
            }
            Console.WriteLine(imposto);
            */
            //-------------------------------------------------------------------------------
            /*
            int senha = 2002;
            bool match = false;
            while (match == false)
            {
                Console.WriteLine("Digite a senha:");
                int digitado = int.Parse(Console.ReadLine());
                if (digitado == senha)
                {
                    match = true;
                    Console.WriteLine("Acesso concedido");
                    break;
                }else
                    Console.WriteLine("Acesso negado");
            }*/

            //--------------------------------------------------------------------------------------
            /*
            int x = 1;
            int y = 1;
            while (x != 0 && y != 0)
            {
                Console.WriteLine("Digite um par de coordenadas:");
                string[] coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro Quadrante");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto Quadrante");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro Quadrante");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo Quadrante");

            }
            Console.WriteLine("");*/
            //----------------------------------------------------------------------------
            /*
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;
            int postoDeCombustivo = int.Parse(Console.ReadLine());

            while (postoDeCombustivo != 4)
            {
                if (postoDeCombustivo == 1)
                {
                    alcool++;
                }
                else if (postoDeCombustivo == 2)
                {
                    gasolina++;
                }
                else if (postoDeCombustivo == 3)
                {
                    diesel++;
                }
                else if (postoDeCombustivo == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Insira um código válido:");
                }

                postoDeCombustivo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(@$"
Alcool: {alcool}
Gasolina: {gasolina}
Diesel: {diesel}");*/
            /*int count = 0;
            int countOut = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    count++;
                else
                    countOut++;

            }
            Console.WriteLine($@"{count} in
{countOut} out");*/
            //Orientação Objeto - Exercicio 1
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Escreva o nome da pessoa 1:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o nome da pessoa 2:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o salario da pessoa 1:");
            p1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Escreva o salario da pessoa 2:");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("A media dos salarios é: " + Pessoa.MaiorSalario(p1.Salario,p2.Salario));


        }


        static int Maior(int a, int b)
        {
            int maior = Math.Max(a, b);
            return maior;
        }

        static int Menor(int a, int b)
        {
            int menor = Math.Min(a, b);
            return menor;
        }



        static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                if (file.EndsWith("sales.json"))
                {
                    salesFiles.Add(file);
                }
            }

            return salesFiles;
        }
    }
}