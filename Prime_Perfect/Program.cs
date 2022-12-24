using System;

using System.Linq;

namespace Prime_prefect_number 
{ 
    public static class Program
{
    public static void Main()
    {

        // a var to count the factors of current unmber 

        int tamp = 0;
        // input  from user to two vars, one for the stsrt and one for the end 
        Console.Write("please Entre the number to start from counting from : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("please Entre the secound number to stop counting to :");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(); // new line to make it more aesthetic 

        for (int i = num1; i <= num2; i++)      //a for loop that starts from num1 to num 2 
        {

            for (int c = 1; c <= i; c++)          // an inner for the loop to start  dividing from 1 to the current number(which is i)  
            {

                if (i % 2 == 0)             // if the number(i) divisble by the number in the inner loop, increment the counter of factors by 1 
                {

                }
                    tamp++;

            }
            if (tamp == 2)                          // if the counter of factors is equal to 2 then the number is divisibableby 2 numbers(which is 1 itself) 
            {

                double perfect = Math.Pow(2, 1) - 1;  // a double var to make the first part of the perfect number equation 
                double perfect2 = Math.Pow(2, 1 - 1);  //same thing but the secound part instead 
                    Console.WriteLine("the prime number is :{0},i"); //print the prime number 
                Console.WriteLine("the perfect number it is:{0}\n", perfect * perfect2); // print the perfect number of the printed prime number then print a new line to make it more aesthetic 
                    tamp = 0; // make the counter of factors = zero to start counting again to another number 


            }
            else
            {

                    tamp = 0; // same idea :) 
                }
            }
        }
    }
}