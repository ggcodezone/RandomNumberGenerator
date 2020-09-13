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
            int Min = 1;
            int Max = 300;

            // this declares an integer array (you can set the number of elements you want in the brackets next to "new int"
            // initializes all of them to their default value which is zero
            int[] numbergen = new int[100];

            Random randNum = new Random();
            for (int i = 0; i < numbergen.Length; i++)
            {
                numbergen[i] = randNum.Next(Min, Max);
            }

            Console.WriteLine(string.Join("\n", numbergen));
            Console.WriteLine("let's find the instances of our target number in this array.");
            
            for(int i= 0; i<numbergen.Length; i++)
            {
                if(numbergen[i]== 20){ //input number you want to look for after [i]==
                    Console.WriteLine("Instance of number found in the array at this position.");
            }
                else
                {
                    Console.WriteLine("There was no instance of the number in this position.");
                }
            }

        }
    }
}
