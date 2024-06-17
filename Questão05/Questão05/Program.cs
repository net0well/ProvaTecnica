namespace Questão05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário:");
            decimal salario;
            while (!decimal.TryParse(Console.ReadLine(), out salario))
            {
                Console.WriteLine("Valor inválido. Digite novamente o salário:");
            }

            Console.WriteLine("Digite o Cargo:");
            string cargo = Console.ReadLine();

            var dadosUsuario = new
            {
                Nome = nome,
                Salario = salario,
                Cargo = cargo
            };

            string path = @"C:\Users\Wellington\Desktop\Prova Técnica - Wellington Neto\dados_usuario.txt";

            string userData = $"Nome: {dadosUsuario.Nome}\nSalário: {dadosUsuario.Salario}\nCargo: {dadosUsuario.Cargo}";

            try
            {
                File.WriteAllText(path, userData);
                Console.WriteLine($"Os dados foram salvos em: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao salvar o arquivo: {ex.Message}");
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}