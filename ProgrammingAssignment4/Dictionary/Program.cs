/*
Author: Bogdan Livadaru
Date: 10.30.2019
CTEC 135: Microsoft Software Development with C#

<Module 5, Programming Assignment 4, Problem 3>

   <Title: Dictionary>
   <Description: I wrote description above each code section>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary use

            //declare a dictionary and initialization it to create 
            // 3 entries: (1, "one"), (2, "two"), and (3, "three"). 
            // Use a combination of initialization 
            // syntax, Add() and [] in your initialization code.

            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {3, "three" }
            };
            dict.Add(1, "one");
            dict[2] = "two";

            //add an additional entry: (99, "ninety-nine")
            dict.Add(99, "ninety-nine");

            //show use of enumerator to see all entries. Print 
            //both the key and value
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", 
                    item.Key, item.Value);
            }

            //reassign the value of 99 to "99" using indexing notation
            dict[99] = "99";

            //print the new value using indexing notation
            Console.WriteLine(dict[99]);

            //remove the 2 item and enumerate over the 
            //whole dictionary to show it's gone
            dict.Remove(2);
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    item.Key, item.Value);
            }




            #endregion
        }
    }
}
