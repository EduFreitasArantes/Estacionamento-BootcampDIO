namespace Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Coloca o encoding para UTF8 para exibir acentuação
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
            string pI = Console.ReadLine().Replace(" ", "").Replace(".", ",");

            if (decimal.TryParse(pI, out decimal pIDecimal))
            {
                precoInicial = pIDecimal;
            }


            Console.WriteLine("Agora digite o preço por hora:");
            string pH = Console.ReadLine().Replace(" ", "").Replace(".", ",");

            if (decimal.TryParse(pH, out decimal pHDecimal))
            {
                precoPorHora = pHDecimal;
            }

            Patio patio = new Patio(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        patio.AdicionarVeiculo();
                        break;

                    case "2":
                        patio.RemoverVeiculo();
                        break;

                    case "3":
                        patio.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}