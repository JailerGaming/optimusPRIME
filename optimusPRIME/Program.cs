using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimusPRIME
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input = 20000; //Last Number in PrimeList
            List<int> Prime = new List<int>(); //Declare Lists
            List<int> Differ = new List<int>(); //Declare Lists 


            bool[] Joined = new bool[Input + 1]; //Use Bool To Identify Prime With True And False And Use The True Values Only
            for (int N = 2; N <= Math.Sqrt(Input); N++) //Identify All Primes Between 2 And 20000(Input) with Sqrt
            {
                if (!Joined[N])

                {
                    for (int i = N * N; i <= Input; i += N) 
                        Joined[i] = true; //If Sqrt Is uneven, It's a Prime
                }
            }
            for (int N = 2; N <= Input; N++) //Find All The PrimeGaps and Store Their Lenghts
            {
                if (!Joined[N])
                {
                    Prime.Add(N);
                }
            }
            for (int a = 0; a < Prime.Count() - 1; a++) //The Program Should Will The Largest Gap By Looking Through The List Of PrimeGaps And Add It 
            {
                Differ.Add(Prime[a + 1] - Prime[a]);
            }


            int MaxDiffer = Differ.Max(); //The Program Identifies MaxDiffer As The Largest Gap Between The Primes, Thus The Differ.Max
            for (int a = 0; a < Prime.Count() - 1; a++) //Identify Which Numbers The Longest Primegap Belongs To
            {
                if (Prime[a + 1] - Prime[a] == MaxDiffer) //Prime[a+1] - Prime[a] Should Equal To The Longest Gap Between The Primes
                {
                    Console.WriteLine(Prime[a] + " " + Prime[a + 1] + " " + (MaxDiffer - 1)); //Write The Two Primes And Their PrimeGaps
                }
            }
            Console.ReadKey(); //Wait For The User To Terminate The Program
        }
    }
}