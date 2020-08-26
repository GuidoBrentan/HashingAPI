using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HashingAPI
{
    class ExibirHashingLinear
    {
        public ExibirHashingLinear()
        {
            string[] nomes = new string[] {"David", "Jennifer", "Donnie", "Mayo", "Raymond", "Bernica",
                                           "Mike", "Clayton", "Beata", "Michael","Felipe", "Silvana",
                                           "Lucia", "Guilherme", "Monica", "Amélia"};
            HashingLinear hashing = new HashingLinear();

            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            WriteLine("Vamos adiconar na tabela Hash o seguinte vetor:\n");

            for (var i = 0; i < nomes.Length; i++)
            {
                if (i == 0)
                    Write(nomes[i]);

                if (i != 0 && i != 8 && i != 9)
                    Write(" | " + nomes[i]);

                if(i == 8)
                    Write(" | " + nomes[i] + "\n");
                if(i == 9)
                    Write(nomes[i]);
            }

            WriteLine("\n\nPressione [ENTER] para continuar");
            ReadLine();
            SetCursorPosition(0, 5);
            WriteLine("                                   ");
            WriteLine("\n \nIremos adicionar utilizando o método de Sondagem Linear: ");

            for (var i = 0; i < nomes.Length; i++)
            {
                if (hashing.Inserir(nomes[i]))
                {
                    SetCursorPosition(0, 10);
                    Write("                               ");
                    SetCursorPosition(0, 10);
                    Write("Inseriu " + nomes[i]);
                    ReadLine();
                }
                SetCursorPosition(0, 10);
                WriteLine("                               ");
            }

            WriteLine("O nosso vetor ficou assim: ");
            for(var i = 0; i < hashing.Hash.Length; i++)
            {
                if (hashing.Hash[i] != null)
                    WriteLine(i + " -> " + hashing.Hash[i]);
            }
            WriteLine("\n\nAperte [ENTER] para terminar");
            ReadLine();
        }
    }
}
