using System;
using System.Collections.Generic;
using System.Text;

namespace HashingAPI
{
    class HashingLinear
    {
        private string[] hash = new string[107];

        public string[] Hash { get => hash; set => hash = value; }

        public bool Inserir(string dado)
        {
            int chave = CalculaHash(dado), chaveAux = chave;

            if (hash[chave] == null)
            {
                hash[chave] = dado;
                return true;
            }
            else
            {
                while (hash[chave] != null)
                {
                    chave++;

                    if (chave == hash.Length)
                        chave = 0;

                    if (chave == chaveAux--)
                        return false;

                    if (hash[chave] == null)
                    {
                        hash[chave] = dado;
                        return true;
                    }
                }
                return false;
            }
        }

        public bool Existe(string dado)
        {
            int chave = CalculaHash(dado), chaveAux = chave;

            if (hash[chave].Equals(dado))
            {
                return true;
            }
            else
            {
                while (chave != chaveAux--)
                {
                    chave++;

                    if (chave > hash.Length)
                        chave = 0;

                    if (hash[chave].Equals(dado))
                        return true;
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
