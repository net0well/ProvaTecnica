namespace Questão02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.Write("Digite a quantidade de morangos (em Kg): ");
                double quantidadeMorango = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de maçãs (em Kg): ");
                double quantidadeMaca = double.Parse(Console.ReadLine());

                

                double precoMorango = (quantidadeMorango <= 5) ? 2.50 * quantidadeMorango : 2.20 * quantidadeMorango;

                double precoMaca = (quantidadeMaca <= 5) ? 1.80 * quantidadeMaca : 1.50 * quantidadeMaca;

                double valorTotal = precoMorango + precoMaca;

                if (quantidadeMorango + quantidadeMaca > 8 || valorTotal > 25.00)
                {
                    valorTotal *= 0.90;  // <-- aplica desc
                }

                Console.WriteLine("O valor a ser pago pelo cliente é: " + valorTotal.ToString("C"));
                Console.WriteLine("--------------------Questão 02---------------------------------");
        }
    }
 }

