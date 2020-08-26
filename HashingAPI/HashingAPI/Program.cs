using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace HashingAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            ExibirMenu();

            do
            {
                switch (opcao)
                {
                    case '1':
                    {
                        new ExibirHashingLinear();
                        ExibirMenu();
                    }
                    break;

                    case '2':
                    {
                        ExibirMenu();
                    }
                    break;

                    case '3':
                    {
                        ExibirMenu();
                    }
                    break;

                    default:
                    {
                        WriteLine("Selecione uma opção valida");
                        ReadLine();
                        ExibirMenu();
                    }
                    break;
                }
            } while (opcao != '9');
    
            WriteLine("Aperte [ENTER] para terminar");
            ReadLine();      

            void ExibirMenu()
            {
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
                Clear();
                WriteLine("----------------------------------------");
                WriteLine("Bem-vindo ao exemplo de Hashing");
                WriteLine("\nSelecione a opção de hashing que deseja vizualizar: ");
                WriteLine("1 - Sondagem Linear");
                WriteLine("2 - Sondagem Quadrática");
                WriteLine("3 - Hashing Duplo");
                WriteLine("9 - Abortar programa\n");
                string linha = ReadLine();
                opcao = linha.Equals("") ? 'w' : linha[0];
                WriteLine("----------------------------------------");
            }
        }
    }
}
