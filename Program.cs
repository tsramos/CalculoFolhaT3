using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados funcionario
            Funcionario funcionario = new Funcionario();  

            Console.WriteLine("Informe o nome do funcionario");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario inical.");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de imposto cobrado (%).");
            funcionario.Imposto = int.Parse(Console.ReadLine());           
            double salarioLiquido = CalculaSalarioLiquido(funcionario.Imposto, funcionario.Salario);
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine("Salario Liquido: " + salarioLiquido);
            string sep = new string('=',50);
            Console.WriteLine(sep);
            Console.WriteLine("Informe qual a porcentagem do aumento");
            int aumento = int.Parse(Console.ReadLine());
            funcionario.Salario = CalculaAumentoSalario(aumento, funcionario.Salario);      
            salarioLiquido = CalculaSalarioLiquido(funcionario.Imposto, funcionario.Salario);
            Console.WriteLine("Salario bruto :" + funcionario.Salario);
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
