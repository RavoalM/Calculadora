
namespace Calculadora.ConsoleApp;

internal class Program
{
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

            string[] linhasTabuada = Calculadora.GerarTabuada(numeroTabuada);

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(linhasTabuada[contador]);
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

        string[] historicoOperacoes = Calculadora.ObterHistoricoDeOperacoes();
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
        decimal n1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        decimal n2 = Convert.ToDecimal(Console.ReadLine());

        decimal resultado = 0;

        if (operacao == "1")
        {
            resultado = Calculadora.Somar(n1, n2);
        }
        else if (operacao == "2")
        {
            resultado = resultado = Calculadora.Subtrair(n1, n2);
        }
        else if (operacao == "3")
        {
            resultado = resultado = Calculadora.Multiplicar(n1, n2);
        }
        else if (operacao == "4")
        {
            while (n2 == 0)
            {
                Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");

                n2 = Convert.ToDecimal(Console.ReadLine());
            }

            resultado = resultado = Calculadora.Dividir(n1, n2);
        }

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
