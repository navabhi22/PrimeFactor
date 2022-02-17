using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeNumber
    {
        public static bool PrimeNum(int N)
        {
            int numOfFact = 0;
            for (int i = 1; i <= N; i++)
            {
                int rimainder = N % i;
                
                if (rimainder == 0)
                {
                    numOfFact++;
                }
               
            }
            
            if (numOfFact == 2)
            { 
                return(true);
                //Console.WriteLine("prime");
            }
            else
            {
                return (false);
                //Console.WriteLine("not prime");
            }
        }
    }
}
