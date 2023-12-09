using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace basics;



class Program
{
    //static List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 6 };
static int mon = 12;
    static void Main(string[] args)
    {

        List<int> nums = new List<int>();

        for (int i = 0; i < 5; i++)
        {

            while (true)
            {
                //   int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    nums.Add(num);
                    Console.Clear();
                   

                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                }
                     Console.ReadLine();
            }

        }
        Console.WriteLine("The largest number entered on the list is :" + nums.Max());
        //nothing here
    }
}
