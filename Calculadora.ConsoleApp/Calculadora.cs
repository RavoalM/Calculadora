namespace Calculadora.ConsoleApp;

public static class Calculadora
{
    static string[] historicoOperacoes = new string[100];
    static int contadorHistorico = 0;
    public static decimal Somar(decimal n1, decimal n2)
    {
        decimal resultado = n1 + n2;
        historicoOperacoes[contadorHistorico] = $"{n1} + {n2} = {resultado}";
        contadorHistorico += 1;
        return resultado;
        
    }

    public static decimal Subtrair(decimal n1, decimal n2)
    {
        decimal resultado = n1 - n2;
        historicoOperacoes[contadorHistorico] = $"{n1} - {n2} = {resultado}";
        contadorHistorico += 1;
        return resultado;
        
    }

    public static decimal Multiplicar(decimal n1, decimal n2)
    {
        decimal resultado = n1 * n2;
        historicoOperacoes[contadorHistorico] = $"{n1}  *  {n2} = {resultado}";
        contadorHistorico += 1;
        return resultado;

    }

    public static decimal Dividir(decimal n1, decimal n2)
    {
        decimal resultado = n1 / n2;
        historicoOperacoes[contadorHistorico] = $"{n1}  /  {n2} = {resultado}";
        contadorHistorico += 1;
        return resultado;

    }

    public static string[] GerarTabuada(int numeroTabuada)
    {
        string[] linhasTabuada = new string[10];

        for (int contador = 1; contador < 10; contador++)
        {
            int resultadoTabuada = numeroTabuada * contador;

            linhasTabuada[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}"; 
        }

        return linhasTabuada;
    }

    public static string[] ObterHistoricoDeOperacoes()
    {
        return historicoOperacoes;
    }

}
