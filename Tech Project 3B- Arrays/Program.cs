/*
 Author: Sachiwa Irugalbandara
 Date: 9/27/2020
 Comment: Tech assignment 3B demostration using arrays.
*/

using System;

namespace Tech_Project_3B__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter any key to continue. 25 elements will be displayed below!");

            /*
              Using try catch block to display the message
            */

            int[] arr = new int[25];
            int i;
            Console.Write("\n\nRead and Print elements of an array; \n");
            

            Console.Write("Input 25 elements in the array\n");
            for(i=0; i<25; i++)
            {
                Console.Write("element - {0} : " ,i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are:");
            for(i=0; i<10; i++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.Write("\n");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
               
           
                 // Following lines are help to display the 25 elements manually.
                 Console.WriteLine("");
                 Console.WriteLine("Let's display our 25 elements manually");
                 Console.WriteLine("Press any key to continue");
                 int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, };
                 Console.WriteLine("____________________________________________________________________________________________");
                 Console.WriteLine("You have entered the number:" + value_of_input);
                 Console.WriteLine("Element value =" + numbers[value_of_input] + " in element #" + value_of_input + "of the array");

               


                 // This message will exit the window
                  Console.WriteLine(" Press any key to exit the window");
                  Console.ReadKey(true);
               
            }// End of try
            catch
            {
                Console.WriteLine("Press any key only to continue!...");
                Console.WriteLine("Press any key to exit the window");
                Console.ReadKey(true);
            }// End of catch
         }// End of Main
    }// End of Class
}// End of namespace
