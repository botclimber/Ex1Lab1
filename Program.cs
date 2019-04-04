/**
 * Author       : Daniel Silva | Carlos Silva
 * Date         : 2019-04-04
 * version      : v0.3
 * 
 * Description  : Verificar se array é ou não simétrico.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 27;
            int[] arr = new int[MAX];
            int nrContent = 0;
            string msg;

            Console.WriteLine(" [-1] para sair: \n");
            for(nrContent = 0; nrContent < MAX; nrContent++)
            {
                Console.WriteLine("Insira um numero: ");
                arr[nrContent] = int.Parse(Console.ReadLine());

                if (arr[nrContent] < 0) break;
            }

            if (Simetric(arr, nrContent) == true)
                msg = "é Simétrico";
            else
                msg = "não é Simétrico";

            Console.WriteLine("O Array gerado "+msg);

            Console.ReadKey();

        }

        public static bool Simetric(int[] arr, int tot)
        {
            /*   */
            int half = tot / 2;

            for (int i = 1; (i-1) <= half; i++)
            {
                if (arr[i - 1] != arr[tot - i])
                    return false;
            }

            return true;
        }
    }
}
