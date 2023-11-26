using System.Globalization;

namespace Estacionamento
{
    public class Patio
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Patio(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Veículo com placa {placa} já está estacionado.");
                Console.ResetColor();
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
                Console.WriteLine();
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    veiculos.Remove(placa);
                    string valorFormatado = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));


                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorFormatado}");
                }
                else
                {
                    Console.WriteLine("Valor de horas inválido.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


        public decimal ConverterParaDecimal(string valor)
        {
            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

            if (decimal.TryParse(valor, NumberStyles.Currency, culturaBrasileira, out decimal resultado))
            {
                return resultado;
            }
            else
            {
                throw new ArgumentException("Formato inválido para conversão para decimal.");
            }
        }
    }
}