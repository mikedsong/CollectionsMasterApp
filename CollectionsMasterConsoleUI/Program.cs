using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
          

            #region Arrays

            
            var numbers = new int[50];


            
            Populater(numbers);

            
            Console.WriteLine(numbers[0]);

                       
            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.WriteLine("All Numbers Original");
            
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");
            
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            ReverseArray(numbers);
            NumberPrinter(numbers);
            

           

            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("sorted numbers");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

          
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);


            Console.WriteLine("-------------------");

           
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);


            Console.WriteLine("\n************End Arrays*************** \n");

            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

          
            var numberslist = new List<int>();
            

            
            Console.WriteLine(numberslist.Capacity);
            

            Populater(numberslist);

           
            Console.WriteLine(numberslist.Capacity);

            Console.WriteLine("---------------------");

            
            bool isANumber;
            int searchNumber;


            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out searchNumber);
            } while (!isANumber);
            
            NumberChecker(numberslist, searchNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            
            NumberPrinter(numberslist);
            Console.WriteLine("-------------------");


            
            Console.WriteLine("Evens Only!!");
            OddKiller(numberslist);
            
            Console.WriteLine("------------------");

            
            Console.WriteLine("Sorted Evens!!");
            numberslist.Sort();
            
            NumberPrinter(numberslist);
            
            Console.WriteLine("------------------");

            
            var listCopy = numberslist.ToArray();

           
            numberslist.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("We have that number!");
            }
            else
            {
                Console.WriteLine("Sorry, we do not have that number!");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            while (numberList.Count <= 50)
            {
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }

        }

        private static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                
                
                start++;
                end--;
                
            }
        }

       
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
