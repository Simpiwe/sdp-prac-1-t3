using System;
using System.Collections.Generic;
using System.Linq;

namespace euler
{

    class Program
    {
        static long LargestPrimeFactor(long number)  
        {  
            #region Get prime factors
            
            List<long> primes = new List<long>(); 
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

        public static int Doug(){
            int sum =0;
            for(int i =1; i<1000;i++){
                if (i%3==0 && i%5==0){//this is redundant, but im going to leave it in anyways
                    sum+=i;
                }
                else if(i%3==0){
                    sum+=i;
                }
                else if(i%5==0){
                    sum+=i;
                }
            }
            return sum;
        }

        public static int[] getnum()
        {
            int[] arr = new int[100];
            int temp = 1;
            int i = 0;
            while (true)
            {
                if (i < 2)
                {
                    arr[i] = temp;
                    temp++;
                    i++;
                }
                else
                {
                    temp = arr[i - 1];
                    temp = temp + arr[i - 2];
                    if (temp > 4000000)
                        break;
                    arr[i] = temp;
                    i++;
                }
            }
            return arr;
        }
        public static int addEven()
        {
            int sum = 0;
            int[] arr = getnum();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    sum = sum + arr[i];
            return sum;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");//600851475143
            Console.WriteLine("Largest prime factor: "+LargestPrimeFactor(600851475143));
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000: "+ Doug());
            int answer = addEven();
            Console.WriteLine("The sum of even-valued numbers less than 4 million in a fibonacci sequence is: " + answer);
        }

    }
}
