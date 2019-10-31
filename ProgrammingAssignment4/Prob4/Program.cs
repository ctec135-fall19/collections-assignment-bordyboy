/*
Author: Bogdan Livadaru
Date: 10.30.2019
CTEC 135: Microsoft Software Development with C#

<Module 5, Programming Assignment 4, Problem 4>

   <Title: Linked List>
   <Description: I wrote description above each code section>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList use

            //Demonstrate use of constructor taking an IEnumerable 
            // object. Create a string array having the first 5-10 
            // words of your favorite nursery rhyme. 
            // Use it as the argument when constructing the LinkedList object.
            LinkedList<String> ll = new LinkedList<string>();
            ll.AddLast
                ("Cause once you through that door it ain't no walking out");

            //Print out the rhyme on a single line
            foreach(string str in ll)
            {
                Console.WriteLine(str);

            }

            /* The traditional way to walk a linked list is to start 
              at the head, process the node, then set the node variable 
              to the next node in the list. Create a node variable and 
              walk the list to print out the values. The line printed 
              should be the same as the one above.
             */
            // ^ Don't know how to do ^

            // Remove a word from the middle of the list. 
            // Print the list on a single line to demonstrate this
            
            ll.Remove(ll.Find("that"));
            foreach (string str in ll)
            {
                Console.WriteLine(str);

            }


            #endregion
        }
    }
}
