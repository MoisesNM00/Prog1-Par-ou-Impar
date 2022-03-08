using System;

namespace Exercicio_1___Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcao = true;

            while (opcao == true)
            {
                //Entrada do numero a ser calculado.
                Console.WriteLine("Escreva um numero: ");
                float.TryParse(Console.ReadLine(), out float n1);

                //Calculando o numero para saber se é par ou impar.
                if (n1 % 2 == 0)
                {
                    Console.WriteLine("O número é Par\n");
                }
                else
                {
                    Console.WriteLine("O número é Ímpar\n");
                }

                //Menu para finalizar ou continuar o teste.
                Console.WriteLine("Deseja sair do teste?\n 1 - Sim.\n 2 - Não.");
                int.TryParse(Console.ReadLine(), out int saida);
                switch (saida)                    
                {

                    case 1:
                        Console.WriteLine("Saindo do programa.\n");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continuando o teste.\n");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando ao teste.\n");
                        break;
                }
            }
        }
    }
}
