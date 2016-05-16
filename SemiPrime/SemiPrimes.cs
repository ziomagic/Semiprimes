using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiPrime
{
    class SemiPrimes
    {
        private int[] P;
        private int[] Q;
        private Random rand = new Random();

        public SemiPrimes(int M)
        {
            InitArrays(M);
        }

        /// <summary>
        /// Method is creating P, and Q arrayy, and fill them with proper content
        /// 
        /// Example:
        /// InitArrays(5); Will create arrays of size 5
        /// </summary>
        /// <param name="size"></param>
        private void InitArrays(int size)
        {
            P = new int[size];
            Q = new int[size];

            for (int i = 0; i < size; i++)
            {
                P[i] = rand.Next(1, 30);
                Q[i] = rand.Next(P[i] + 1, P[i] + 30);
            }
        }


    }
}
