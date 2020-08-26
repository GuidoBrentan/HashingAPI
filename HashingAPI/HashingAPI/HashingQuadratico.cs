using System;
using System.Collections.Generic;
using System.Text;

namespace HashingAPI
{
    class HashingQuadratico
    {
        private string[] hash = new string[107];

        public string[] Hash { get => hash; set => hash = value; }

        public bool Inserir(string dado)
        {
            int chave = CalculaHash(dado), qtdTentativas = 0;

            if (hash[chave] == null)
            {
                hash[chave] = dado;
                return true;
            }
            else
            {
                while(hash[chave] != null)
                {
                    qtdTentativas++;

                    chave = chave + qtdTentativas^2;

                    if (chave >= hash.Length)
                        chave = chave - hash.Length;

                    if (qtdTentativas == hash.Length)
                        return false;

                    if(hash[chave] == null)
                    {
                        hash[chave] = dado;
                        return true;
                    }
                }
                return false;
            }
        }

        private int CalculaHash(string dado)
        {
            int chave = 0;

            for (var i = 0; i < dado.Length; i++)
                chave += 7 * chave + dado[i];

            chave = chave % hash.Length;

            if (chave < 0)
                chave += hash.Length;

            return chave;
        }
    }
}
