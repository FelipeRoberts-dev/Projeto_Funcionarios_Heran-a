using System;
using System.Collections.Generic;
using FuncionarioHerança.Entidades;
using System.Globalization;
namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do objeto Lista Funcionarios. 
            List<Funcionarios> funcionarios = new List<Funcionarios>();

                  

            Console.Write("Entre com quantos funcionários serão: ");

            int n = int.Parse(Console.ReadLine());

            //Realizando a leitura de quantos funcionarios serão e armazenar na lista.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}: ");
                Console.Write("Tecerizado (s/n)? ");

                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor Horas: ");

                double vlhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 's')
                {
                    Console.Write("Valor Adicional: ");
                    double vlAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    //Adicionando na lista os funcionarios que serão tercerizados.
                    funcionarios.Add(new FuncionarioTercerizado(nome, horas, vlhoras, vlAdicional));
                }
                else
                {
                    funcionarios.Add(new Funcionarios(nome, horas, vlhoras));
                }


            }
            Console.WriteLine();

            Console.WriteLine("Pagamento: ");

            foreach(Funcionarios fun in funcionarios)
            {
                Console.WriteLine(fun.Nome + " - & " + fun.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}