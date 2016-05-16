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

        /// <summary>
        /// It will find Semi prime number from specific range
        /// 
        /// Example:
        /// GetSemiPrime(1, 26) Will return 10
        /// </summary>
        /// <param name="from">Range start</param>
        /// <param name="to">Range end</param>
        /// <returns>Semiprime number, or -1 if semiprime not found</returns>
        public int GetSemiPrime(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                if(isSemiPrime(i))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Get list of all semi primes between Q, and P
        /// </summary>
        /// <returns>List of semiprimes</returns>
        public List<int> GetSemiPrimeList()
        {
            List<int> output = new List<int>();
            for(int i = 0; i < P.Length; i++)
            {
                int semi = GetSemiPrime(P[i], Q[i]);
                if(semi > -1)
                {
                    output.Add(semi);
                }
            }

            return output;
        }
        /// <summary>
        /// Function will check if specific number is semiprime
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Number semiprime status</returns>
        bool isSemiPrime(int c)
        {
            int a = 2, b = 0;
            while (b < 3 && c != 1)
            {
                if ((c % a) == 0)
                {
                    c /= a; b++;
                }
                else
                    a++;
            }
            return b == 2;
        }
    }
}
