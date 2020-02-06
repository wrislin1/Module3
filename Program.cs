/* 
 Widler Rislin
 9/22/2019
 CEN 4370C
 Module 3 Assignment
 This Program reads in 10 numbers from a user, keeping track of the maximum and minimum numbers, it then outputs the max and min values.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max=0, min=0, count=0; //int variables holding user input, the max, min values and number counter.
            

            while(count!=10) //while loop that continues until user enters 10 numbers.
            {
              
                Console.Write("Please enter a number, then press Enter: " ); // Prompts user for a number.
                num=int.Parse(Console.ReadLine()); // Reads number into variable num.
                if(count==0)  // Checks to see if this the first time the loop is being run.
                {
                    //sets max and min valus to num if this is the first run.
                    max = num;
                    min = num;
                }

                if(num>max) //checks if num is greater than current max, if yes max is set to num.
                {
                    max = num;
                }
                else if(num<min) //checks to see if num is less than current min, if yes set min to num.
                {
                    min = num;
                }
                count++; // increases count by 1 after loop runs to keep track of numbers entered.
            }
            // Outputs max and min values.
            Console.WriteLine();
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.WriteLine();



        }
    }
}
