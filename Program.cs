using System;

namespace homeWorkSubarrayRepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int arraySize = 30;
            int[] array = new int[arraySize];

            int minRangeValue = 1;
            int maxRangeValue = 5;
            int counter = 1;
            int maxCounter = 0;

            string line = "";

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(minRangeValue, maxRangeValue);
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        line = array[i].ToString();
                    }
                    else if (counter == maxCounter)
                    {
                        line += $", {array[i].ToString()}";
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine($"Число {line} повторяется {maxCounter} раз.");
        }
    }
}
