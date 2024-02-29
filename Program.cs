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
            Console.WriteLine(funcionario);
            Console.WriteLine("Informe qual a porcentagem do aumento");
            int aumento = int.Parse(Console.ReadLine());
            funcionario.CalculaAumentoSalario(aumento);     
            Console.WriteLine(funcionario.ToString());
        }
    }
}
