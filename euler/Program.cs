using System;
using System.Collections.Generic;
using System.Linq;

namespace euler
{

    class Program
    {
        static int LargestPrimeFactor(int number)  
        {  
            #region Get prime factors
            
            List<int> primes = new List<int>(); 
            if (number % 2 == 0)
                primes.Add(2);

            //eliminate all even numbers
            while (number % 2 == 0)  
            {   
                number = number/2;
            }  
        
            for (int i = 3; i <= Math.Sqrt(number); i += 2)  
            {   
                while (number % i == 0)  
                {  
                    primes.Add(number);
                    number /= i; 
                }  
            }  
        
            if (number > 2)  
                primes.Add(number);
            
            #endregion

            //return the largest prime factor
            return primes.Max();
        } 
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
