﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Squared_Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializes a new instance of the Random class
            // creates a list called numbers
            // populate the list
            // if i is less than 20, add a random number between 1 and 50 to the numbers list
            Random random = new Random(50);          
            {
             var numbers = new List<int>();    
             for(int i = 0; i < 20; i++)           
                {
                    numbers.Add(random.Next(1, 50));
                }

             // create a new list to hold the resulting squared numbers
             // loop through the numbers list
             // for each random number, multiply its value by itself and add it to the new list
             var squaredNumbers = new List<int>();
             foreach (int number in numbers)
                {
                    squaredNumbers.Add(number * number);
                }
               
            // removes all odd numbers from the squaredNumbers list
                squaredNumbers.RemoveAll(i => i % 2 == 1);
            }
        }
    }
}