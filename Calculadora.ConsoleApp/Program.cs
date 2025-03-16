
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;

        static void Main(string[] args)
        {

            while (true)
            {
                // exibe o menu
                string opcao = ExibirMenu();

                //Sair
                if (SairEscolhida(opcao))
                {
                    break;
                }

                // Tabuada
                else if (TabuadaEscolhida(opcao))
                {
                    ExibirTabuada();
                }

                //Histórico
                else if (HistoricoEscolhida(opcao))
                {
                    ExibirHistorico();
                }

                else
                {
                    ExibirResultado(RealizarCalculo(opcao));
                }
            }
        }


        static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("=======================================");

            //menu
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Subtração");
            Console.WriteLine("3.Multiplicação");
            Console.WriteLine("4.Divisão");
            Console.WriteLine("5.Tabuada");
            Console.WriteLine("H.Histórico");
            Console.WriteLine("S.Sair");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();//ToUpper converte a string para maiúscula

            return opcao;
        }

        static bool SairEscolhida(string opcao)
        {
            bool SairEscolhida = opcao == "S";

            return SairEscolhida;
        }

        static bool TabuadaEscolhida(string opcao)
        {
            bool TabuadaEscolhida = opcao == "5";

            return TabuadaEscolhida;
        }

        static bool HistoricoEscolhida(string opcao)
        {
            bool HistoricoEscolhida = opcao == "H";
            return HistoricoEscolhida;
        }

        static void ExibirTabuada()
        {
            {
                Console.WriteLine("\n===== TABUADA =====");
                Console.WriteLine("=======================================");

                Console.Write("Digite o número da tabuada: ");
                int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                for (int contador = 1; contador <= 10; contador++)
                {
                    int resultadoTabuada = numeroTabuada * contador;

                    //string linhaTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;
                    Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}"); //interpolação
                }

                Console.WriteLine("=======================================");
                Console.Write("Aperte ENTER para continuar");
                Console.ReadLine();
            }
        }

        static void ExibirHistorico()
        {
            Console.WriteLine("\n===== HISTÓRICO =====");
            Console.WriteLine("=======================================");

            for (int contador = 0; contador < historicoOperacoes.Length; contador++)
            {
                string valorAtual = historicoOperacoes[contador];

                if (valorAtual != null)
                    Console.WriteLine(valorAtual);
            }

            Console.WriteLine("\nAperte ENTER para continuar");
            Console.ReadLine();
        }

        static decimal RealizarCalculo(string operacao)
        {
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;

            if (operacao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (operacao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            }
            else if (operacao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            }
            else if (operacao == "4")
            {
                while (segundoNumero == 0)
                {
                    Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");

                    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                }

                resultado = primeiroNumero / segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }

            contadorHistorico += 1;

            return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));
            Console.WriteLine("=======================================");
            Console.WriteLine("\nAperte ENTER para continuar");
            Console.ReadLine();
        }
    }
}
