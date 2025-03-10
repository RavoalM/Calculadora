
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Calculadora Tabajara 2025");

                //menu
                Console.WriteLine("1.Soma");
                Console.WriteLine("2.Subtração");
                Console.WriteLine("3.Multiplicação");
                Console.WriteLine("4.Divisão");
                Console.WriteLine("E.Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                String opcao = Console.ReadLine();
                String opcaoValida = opcao.ToUpper();//ToUpper converte a string para maiúscula



                //Sair
                if (opcaoValida == "E")
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double n1s = Console.ReadLine();
                double n1 = Convert.ToInt32(n1s);

                Console.Write("Digite o segundo número: ");
                string n2s = Console.ReadLine();
                double n2 = Convert.ToInt32(n2s);

                double resultado = 0;

                //Soma
                else if (opcaoValida == "1")
                {

                    //processo
                    resultado = n1 + n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da soma: " + resultado);
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Deseja continuar (S/N): ");


                    Console.ReadLine();
                }


                //Subtração
                else if (opcaoValida == "2")
                {

                    //processo
                    resultado = n1 - n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2); 
                    Console.WriteLine("Resultado da sua subtração é: " + resultado);
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Deseja continuar (S/N): ");

                    Console.ReadLine();
                }


                //Multiplicação
                else if (opcaoValida == "3")
                {

                    //processo
                    resultado = n1 * n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da sua multiplacação é: " + resultado);
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Deseja continuar (S/N): ");

                    Console.ReadLine();
                }


                //Divisão
                else if (opcaoValida == "4")
                {

                    //processo
                    resultado = n1 / n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da sua divisão é: " + resultado);
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Deseja continuar (S/N): ");

                    Console.ReadLine();
                }


                else if (opcaoValida == "")
                {
                    Console.WriteLine("Opção inválida, por favor escolha uma opção válida");

                    break;
                }

            
            }
        }
    }
}
