using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(numbers[numbers.Length - 1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(numbers);
            Console.WriteLine("Multiple of three = 0: ");
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            SortNumbers(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var intList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity: ");
            Console.WriteLine(intList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);

            //TODO: Print the new capacity
            Console.WriteLine("Generated list. New capacity: ");
            Console.WriteLine(intList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int key = -1;
            bool validInput = false;
            while (!validInput)
            {
                
                validInput = int.TryParse(Console.ReadLine(), out key);
                if (!validInput)
                {
                    Console.WriteLine("Error: must be an integer:");
                }
            }
            NumberChecker(intList, key);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var intArray = new int?[intList.Count];
            for (int i = 0; i < intList.Count; i++)
            {
                intArray[i] = intList[i];
            }
            
            //TODO: Clear the list
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = null;
            }

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void SortNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int a = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > a)
                    {
                        a = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = a;
                    }
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (int num in numberList.ToList())
            {
                if (num % 2 == 1)
                {
                    numberList.Remove(num);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            int i = 0;
            foreach (int num in numberList)
            {
                if (num == searchNumber)
                {
                    i++;
                }
            }
            Console.WriteLine($"{searchNumber} appears in the list {i} times");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
                
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int temp;
            int i = 0;
            for (int j = array.Length - 1; j > i; j--)
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                i++;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
