/*
Author: Bogdan Livadaru
Date: 10.30.2019
CTEC 135: Microsoft Software Development with C#

<Module 5, Programming Assignment 4, Problem 1>

   <Title: Arrays and Lists>
   <Description: I wrote description above each code section>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple Array

            // create an array of int of size 5
            // sa = simpleArray
            int[] sa = new int[5];
            int count = 11;
            for(int i=0; i<sa.Length; i++)
            {
                
                sa[i] = count + i;
            }
            // print out each int in the array
            foreach(int element in sa)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region List <T>
            // sl = simple List
            List<int> sl = new List<int>();
            // use a for loop to initialize the list to 
            // the numbers 21 - 25
            for (int l = 0; l < 5; l++)
            {
                sl.Add(l + 21);
            }
            // use a foreach loop to print out the 
            // values in the list
            foreach (int element in sl)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            // update the values in the list 
            // to 31 - 35 using indexing
            for (int l = 0; l < 5; l++)
            {
                sl[l] = l+31;
            }
            // repeat the print using a for loop and indexing
            for (int l = 0; l < 5; l++)
            {
                Console.WriteLine(sl[l]);
            }

            #endregion

        }
    }
}
