using System;

namespace Calculadora_Idade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis

            float anoNascimento, anoAtual, idade, idadeSemana;

            //entrada de dados
            Console.Write(" Digite o ano de nascimento ");
            anoNascimento = float.Parse(Console.ReadLine());

            Console.Write(" Digite o ano atual ");
            anoAtual = float.Parse(Console.ReadLine());

            //processamento

            idade = (anoAtual - anoNascimento);
            Console.WriteLine("A idade é de: "+idade+ " anos ");

            idadeSemana = (idade*48);
            Console.WriteLine("A idade em semanas é de: "+idadeSemana+ " semanas ");


        }
    }
}
