/**
 * Author       : Daniel Silva | Carlos Silva
 * Date         : 2019-04-04
 * version      : v0.3
 * 
 * Description  : Verificar se array é ou não simétrico.
 * */

using System;

namespace Ex1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variaveis
            /// <summary>
            /// Declaração de variaveis
            /// <para><c>cont int Max = 27</c> valor maximo aleatorio</para>
            /// </summary>
            const int MAX = 27;
            int[] arr = new int[MAX];
            int nrContent = 0;
            string msg;
            #endregion

            #region Interação com utilizador
            Console.WriteLine(" [-1] para sair: \n");
            for(nrContent = 0; nrContent < MAX; nrContent++)
            {
                Console.WriteLine("Insira um numero: ");

                /// <summary>
                /// <c>int.Parse</c> Converte string em inteiro
                /// </summary>
                arr[nrContent] = int.Parse(Console.ReadLine());

                /// <para>condição de paragem</para>
                if (arr[nrContent] < 0) break;
            }
            #endregion

            #region Conclusão
            if (Simetric(arr, nrContent) == true)
                msg = "é Simétrico";
            else
                msg = "não é Simétrico";

            Console.WriteLine("O Array gerado "+msg);
            #endregion

            Console.ReadKey();

        }

        #region Metodo Verifica Simetrico
        /// <summary>
        ///    Metodo que verifica a simetria do array
        /// </summary>
        /// <param name="arr"> Array de int valores a receber</param>
        /// <param name="tot"> Numero total de valores int no array</param>
        /// <returns>bool</returns>

        public static bool Simetric(int[] arr, int tot)
        {
            // divide array
            int half = tot / 2;

            for (int i = 1; (i-1) <= half; i++)
            {
                // compara array divido posicao (i-1) com a posicao (tot-i)
                if (arr[i - 1] != arr[tot - i])
                    return false;
            }

            return true;
        }
        #endregion
    }
}
