namespace Questão01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de carros vendidos: ");
            int numeroDeCarrosVendidos = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor total das vendas: ");
            double valorTotalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o salário fixo do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da comissão por carro vendido: ");
            double comissaoPorCarro = double.Parse(Console.ReadLine());

            
            double totalComissaoCarros = numeroDeCarrosVendidos * comissaoPorCarro;

            double comissaoSobreVendas = valorTotalVendas * 0.05;
        
            double salarioFinal = salarioFixo + totalComissaoCarros + comissaoSobreVendas;
  
            Console.WriteLine("O salário final do vendedor é: " + salarioFinal.ToString("C"));
            Console.WriteLine("----------- Teste Técnioc - Questão 01 ----------------------");
        }
    }
}
