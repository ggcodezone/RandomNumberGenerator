using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

//Name:Random Number Generator
//Author: Gwen Kalasky
//Synopsis: Generates list of random numbers and displays, you can set how many numbers you would like generated
//Date: 9/8/20

namespace Rnadomnumbergen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i=0; i<100; i++) // i < number of elements to put in the array
            {
                Console.WriteLine(random.Next());
            }

            Console.ReadLine();

        }
    }
}
