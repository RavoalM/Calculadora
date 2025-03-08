
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            //menu
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Subtração");
            Console.WriteLine("3.Multiplicação");
            Console.WriteLine("4.Divisão");
            Console.WriteLine("E.Sair");

            String opcao = Console.ReadLine();
            String opcaoValida = opcao.ToUpper();//ToUpper converte a string para maiúscula

            //Sair
            if (opcaoValida == "E")
            {
                return;
            }


            //Soma
            else if (opcaoValida == "1")
            {

                //coleta de dados

                Console.Write("\nPor favor digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Por favor digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());


                //processo
                double resultado = n1 + n2;

                //saida
                Console.WriteLine("\n=======================================");
                Console.WriteLine("O primeiro número é: " + n1);
                Console.WriteLine("O segundo número é: " + n2);
                Console.WriteLine("Resultado da soma: " + resultado);
                Console.WriteLine("=======================================");

                Console.ReadLine();
            }


            //Subtração
            else if (opcaoValida == "2")
            {

                //coleta de dados
                Console.Write("\nPor favor digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Por favor digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());


                //processo
                double resultado = n1 - n2;

                //saida
                Console.WriteLine("\n=======================================");
                Console.WriteLine("O primeiro número é: " + n1);
                Console.WriteLine("O segundo número é: " + n2);
                Console.WriteLine("Resultado da sua subtração é: " + resultado);
                Console.WriteLine("=======================================");

                Console.ReadLine();
            }


            //Multiplicação
            else if (opcaoValida == "3")
            {

                //coleta de dados
                Console.Write("\nPor favor digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Por favor digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());


                //processo
                double resultado = n1 * n2;

                //saida
                Console.WriteLine("\n=======================================");
                Console.WriteLine("O primeiro número é: " + n1);
                Console.WriteLine("O segundo número é: " + n2);
                Console.WriteLine("Resultado da sua multiplacação é: " + resultado);
                Console.WriteLine("=======================================");

                Console.ReadLine();
            }


            //Divisão
            else if (opcaoValida == "4")
            {

                //coleta de dados
                Console.Write("\nPor favor digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Por favor digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());


                //processo
                double resultado = n1 * n2;

                //saida
                Console.WriteLine("\n=======================================");
                Console.WriteLine("O primeiro número é: " + n1);
                Console.WriteLine("O segundo número é: " + n2);
                Console.WriteLine("Resultado da sua divisão é: " + resultado);
                Console.WriteLine("=======================================");

                Console.ReadLine();
            }


            else if (opcaoValida == "")
            {
                Console.WriteLine("Opção inválida, por favor escolha uma opção válida");
            }
        }
    }
}
