using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados funcionario
            string nome;
            double salario;
            int imposto;

            Console.WriteLine("Informe o nome do funcionario");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o salario inical.");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de imposto cobrado (%).");
            imposto = int.Parse(Console.ReadLine());           
            double salarioLiquido = CalculaSalarioLiquido(imposto, salario);
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine("Salario Liquido: " + salarioLiquido);
            string sep = new string('=',50);
            Console.WriteLine(sep);
            Console.WriteLine("Informe qual a porcentagem do aumento");
            int aumento = int.Parse(Console.ReadLine());
            salario = CalculaAumentoSalario(aumento, salario);      
            salarioLiquido = CalculaSalarioLiquido(imposto, salario);
            Console.WriteLine("Salario bruto :" + salario);
            Console.WriteLine("Salario liquido :" + salarioLiquido);
        }

        public static double CalculaAumentoSalario(int taxa, double salario)
        {
            double aumento = salario * taxa / 100;
            return salario + aumento;
        }

        public static double CalculaSalarioLiquido(int imposto , double salario)
        {
            double desconto = salario * imposto / 100;
            return salario - desconto;
        }
    }
}
