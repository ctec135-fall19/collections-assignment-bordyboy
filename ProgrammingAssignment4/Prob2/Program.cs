/*
Author: Bogdan Livadaru
Date: 10.30.2019
CTEC 135: Microsoft Software Development with C#

<Module 5, Programming Assignment 4, Problem 2>

   <Title: Stacks and Queues>
   <Description: I wrote description above each code section>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack

            // declare and initialize a stack with 
            // the numbers 1 - 5 using initialization syntax.
            Stack<int> stackOfNumbers = new Stack<int>();

            stackOfNumbers.Push(1);
            stackOfNumbers.Push(2);
            stackOfNumbers.Push(3);
            stackOfNumbers.Push(4);
            stackOfNumbers.Push(5);
            Console.WriteLine();

            //demonstrate use of the enumerator to print out 
            // the members in the stack, i.e. write a foreach loop
            foreach (int n in stackOfNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // print a peek at the top member in the stack
            Console.WriteLine(stackOfNumbers.Peek());
            Console.WriteLine();

            // write a loop that pops the elements off of the 
            // stack and prints each
            while (stackOfNumbers.Count > 0)
                Console.WriteLine(stackOfNumbers.Pop());
            Console.WriteLine();
            #endregion

            #region Queue

            // declare a queue
            Queue<int> numbersQueue = new Queue<int>();

            //initialize the queue with the numbers 1-5 using a for loop.
            for(int n = 1; n < 6; n++)
            {
                numbersQueue.Enqueue(n);
            }

            //demonstrate use of the enumerator to print 
            // out the members in the queue, i.e. write a foreach loop
            foreach (int num in numbersQueue)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //print a peek at the top member in the stack
            Console.WriteLine(numbersQueue.Peek());
            Console.WriteLine();

            //write a loop that dequeues the elements 
            // from the stack and prints each
            while (numbersQueue.Count > 0)
                Console.WriteLine(numbersQueue.Dequeue());
            Console.WriteLine();


            #endregion

        }
    }
}
