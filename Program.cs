using System;

namespace homeWorkSubarrayNumberesRepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int arrayNumberesSize = 30;
            int[] arrayNumberes = new int[arrayNumberesSize];

            int minRangeValue = 1;
            int maxRangeValue = 5;
            int counter = 1;
            int maxCounter = 0;

            string line = "";

            for (int i = 0; i < arrayNumberesSize; i++)
            {
                arrayNumberes[i] = random.Next(minRangeValue, maxRangeValue);
            }

            foreach (int numberes in arrayNumberes)
            {
                Console.Write(numberes + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arrayNumberes.Length - 1; i++)
            {
                if (arrayNumberes[i] == arrayNumberes[i + 1])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        line = arrayNumberes[i].ToString();
                    }
                    else if (counter == maxCounter)
                    {
                        line += $", {arrayNumberes[i].ToString()}";
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
