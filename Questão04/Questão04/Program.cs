namespace Questão04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteInferior = -1024;
            int limiteSuperior = 1024;

            try
            {
                Console.Write("Digite o primeiro valor inteiro: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo valor inteiro: ");
                int valor2 = Convert.ToInt32(Console.ReadLine());

                if (valor1 < limiteInferior || valor1 > limiteSuperior || valor2 < limiteInferior || valor2 > limiteSuperior)
                {
                    Console.WriteLine("Valores devem estar entre -1024 e 1024.");
                    return;
                }

                int soma = valor1 + valor2;

                if ((valor1 > 0 && valor2 > 0 && soma < 0) || (valor1 < 0 && valor2 < 0 && soma >= 0))
                {
                    Console.WriteLine("Ops, foi ocasionado um overflow, então retornou 0.");
                    soma = 0;
                }
                else if ((valor1 < 0 && valor2 > 0 && soma > 0) || (valor1 > 0 && valor2 < 0 && soma < 0))
                {
                    Console.WriteLine("Ops, foi ocasionado um underflow, então retornou 0.");
                    soma = 0;
                }

                Console.WriteLine($"A soma dos valores é: {soma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: A entrada deve ser um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: O número digitado está fora do intervalo permitido para um inteiro.");
            }

        }
    }
}