using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            //#1
            Console.WriteLine("Enter x");
            number = Console.ReadLine();
            int x = int.Parse(number);
            int firstNumber = 7;
            int secondNumber = 3;
            int thirdNumber = 3;
            int y = firstNumber * x * x - secondNumber * x + thirdNumber;

            Console.WriteLine("y = " + y);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#2
            Console.Clear();
            Console.WriteLine("Enter radius");
            number = Console.ReadLine();
            int radius = int.Parse(number);
            int radiusesInDiameter = 2;
            int diameter = radius * radiusesInDiameter;

            double circleLength = diameter * Math.PI;
            double circleArea = radius * radius * Math.PI;

            Console.WriteLine("Length = " + circleLength);
            Console.WriteLine("Area = " + circleArea);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#3
            Console.Clear();
            Console.WriteLine("Enter distance in santimeters");
            number = Console.ReadLine();
            int distance = int.Parse(number);
            int santimetersInMeter = 1000;
            int distanceInMeters = distance / santimetersInMeter;
            Console.WriteLine("Distance in meters = " + distanceInMeters);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#4
            Console.Clear();
            Console.WriteLine("Enter days");
            int days = int.Parse(Console.ReadLine());
            int daysInWeek = 7;
            int weeksInDays = days / daysInWeek;
            Console.WriteLine("Passed weeks = " + weeksInDays);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#5
            Console.Clear();
            Console.WriteLine("Enter number(two-digit)");
            number = Console.ReadLine();
            int usingNumber = int.Parse(number);
            int decade = 10;
            int size = 0;
            int sumOfNumbers = 0;
            int multiplyOfNumbers = 1;

            for (int i = usingNumber; i > 0; i /= decade)
            {
                size++;
            }

            if (size == 2)
            {
                int[] numbersInArray = new int[size];

                for (int i = 0, q = usingNumber; i < numbersInArray.Length; i++, q /= 10)
                {
                    numbersInArray[i] = q % 10;
                }
                for (int i = 0; i < size / 2; i++)
                {
                    int tmp = numbersInArray[i];
                    numbersInArray[i] = numbersInArray[size - i - 1];
                    numbersInArray[size - i - 1] = tmp;
                }
                int decadePosition = 2;
                int decadesCounter = numbersInArray[size - decadePosition];

                int unitPostition = 1;
                int unitsCounter = numbersInArray[size - unitPostition];


                for (int i = 0; i < numbersInArray.Length; i++)
                {
                    sumOfNumbers += numbersInArray[i];
                }
                for (int i = 0; i < numbersInArray.Length; i++)
                {
                    multiplyOfNumbers *= numbersInArray[i];
                }

                Console.WriteLine("Decade = " + decadesCounter);
                Console.WriteLine("Unit = " + unitsCounter);
                Console.WriteLine("Sum of all numbers = " + sumOfNumbers);
                Console.WriteLine("Multiply of all numbers = " + multiplyOfNumbers);
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#6
            Console.Clear();
            size = 0;

            Console.WriteLine("Enter number(four-digit)");
            number = Console.ReadLine();
            int parsedNumber = int.Parse(number);



            sumOfNumbers = 0;
            multiplyOfNumbers = 1;

            for (int i = parsedNumber; i > 0; i /= decade)
            {
                size++;
            }
            if (size == 4)
            {
                int[] numbersInArray = new int[size];

                for (int i = 0, q = parsedNumber; i < numbersInArray.Length; i++, q /= 10)
                {
                    numbersInArray[i] = q % 10;
                }
                for (int i = 0; i < size / 2; i++)
                {
                    int tmp = numbersInArray[i];
                    numbersInArray[i] = numbersInArray[size - i - 1];
                    numbersInArray[size - i - 1] = tmp;
                }

                for (int i = 0; i < numbersInArray.Length; i++)
                {
                    sumOfNumbers += numbersInArray[i];
                    multiplyOfNumbers *= numbersInArray[i];
                }
                Console.WriteLine("Sum of all numbers = " + sumOfNumbers);
                Console.WriteLine("Multiply of all numbers = " + multiplyOfNumbers);
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#7
            Console.Clear();
            size = 0;
            Console.WriteLine("Enter resulting number(three-digit)");
            number = Console.ReadLine();
            int resultingNumber = int.Parse(number);

            for (int i = resultingNumber; i > 0; i /= decade)
            {
                size++;
            }
            if (size == 3)
            {
                int[] numbers = new int[size];

                for (int i = 0, q = resultingNumber; i < numbers.Length; i++, q /= 10)
                {
                    numbers[i] = q % 10;
                }
                for (int i = 0; i < size / 2; i++)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[size - i - 1];
                    numbers[size - i - 1] = tmp;
                }

                int secondTmp = numbers[size - 2];
                numbers[size - 2] = numbers[size - 1];
                numbers[size - 1] = secondTmp;

                Console.WriteLine();
                Console.WriteLine("X number is");
                foreach (int i in numbers)
                {
                    Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            //#8
            Console.Clear();
            Console.WriteLine("Enter 1st boolean value");
            bool X = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd boolean value");
            bool Y = Boolean.Parse(Console.ReadLine());
            bool result;

            
            result = !X && !Y;
            result = X || (!X && Y);
            result = (!X && Y) || Y;
            Console.WriteLine("Result is " + result);
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}