using System;
using System.Collections.Generic;
using System.Linq;

namespace Letterscount
{
    class Program
    {

        public static string CountCharactersInSentence(string inputString)
        {

            Char CharCount;
            inputString = "Hello world";
            int Count = 0;

            CharCount = Convert.ToChar(Console.ReadLine());

            foreach (char item in inputString)
            {
                if (item == CharCount)
                {
                    {
                        Count++;
                    }
                }

            }                      return (Count);


               }

        public static void Main()

        {
            string Words = "Hello world";


            string CharCounts = Words.CountCharactersInSentence("Hello world");

            
            {
                Console.WriteLine(CharCounts);
            }
        }
    }
}

