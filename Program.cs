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
            double salarioLiquido = funcionario.CalculaSalarioLiquido();
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine("Salario Liquido: " + salarioLiquido);
            string sep = new string('=',50);
            Console.WriteLine(sep);
            Console.WriteLine("Informe qual a porcentagem do aumento");
            int aumento = int.Parse(Console.ReadLine());
            funcionario.CalculaAumentoSalario(aumento);     
            salarioLiquido = funcionario.CalculaSalarioLiquido();
            Console.WriteLine("Salario bruto :" + funcionario.Salario);
            Console.WriteLine("Salario liquido :" + salarioLiquido);
        }
    }
}
