using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static void PrimeFactor(int N)
        {
            
            for (int i = 1; i <= N; i++)
            {
                
                int y = N % i ;
                if (y==0 && PrimeNumber.PrimeNum(i)==true )
                {
                    
                        Console.WriteLine(i);

                }

            }
            
        }
    }
}
