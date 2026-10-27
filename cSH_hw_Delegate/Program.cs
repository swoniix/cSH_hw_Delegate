using System;

delegate int[] NumbersDelegate(int[] numbers);
class Program
{
    static int[] IsEven(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result[index++] = numbers[i];
            }
        }
        return result;
    }

    static int[] IsOdd(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                result[index++] = numbers[i];
            }
        }
        return result;
    }

    static int[] GetPrime(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isPrime = true;

            if (numbers[i] < 2)
                isPrime = false;

            for (int j = 2; j < numbers[i]; j++)
            {
                if (numbers[i] % j == 0)
                    isPrime = false;
            }

            if (isPrime)
                count++;
        }
        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isPrime = true;

            if (numbers[i] < 2)
                isPrime = false;

            for (int j = 2; j < numbers[i]; j++)
            {
                if (numbers[i] % j == 0)
                    isPrime = false;
            }

            if (isPrime)
            {
                result[index] = numbers[i];
                index++;
            }
        }

        return result;
    }
    static int[] GetFibonacci(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            long a = 0;
            long b = 1;

            while (a < numbers[i])
            {
                long next = a + b;
                a = b;
                b = next;
            }

            if (a == numbers[i])
                count++;
        }

        int[] result = new int[count];
        int index = 0;
        //запись в новый массив
        for (int i = 0; i < numbers.Length; i++)
        {
            long a = 0;
            long b = 1;

            while (a < numbers[i])
            {
                long next = a + b;
                a = b;
                b = next;
            }

            if (a == numbers[i])
            {
                result[index] = numbers[i];
                index++;
            }
        }
        return result;
    }
    static void Main()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5, 8, 9, 13, 15, 21 };
        NumbersDelegate[] operations =
        {
            IsEven,
            IsOdd,
            GetPrime,
            GetFibonacci
        };

        Console.WriteLine("1 — Even");
        Console.WriteLine("2 — Odd");
        Console.WriteLine("3 — Prime");
        Console.WriteLine("4 — Fibonacci numbers");
        Console.Write("Your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= 4)
        {
            int[] result = operations[choice - 1](numbers);

            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            Console.WriteLine("Incorrect choice.");
        }
    }
}