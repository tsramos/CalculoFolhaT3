namespace CalculoFolha
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public int Imposto;

        public double CalculaSalarioLiquido()
        {
            double desconto = Salario * Imposto / 100;
            return Salario - desconto;
        }

        public void CalculaAumentoSalario(int aumento)
        {
            double valorAumento = Salario * aumento /100;
            Salario += valorAumento;
        }

        public override string ToString()
        {
            string sep = new string('=', 50);
            double salarioLiquido = CalculaSalarioLiquido();
            string mensagem = $"{sep}\nNome: {Nome}\nSalario bruto: {Salario.ToString("C")}\nSalario liquido {salarioLiquido.ToString("C")}\n{sep}";
            return mensagem;
        }
    }
}