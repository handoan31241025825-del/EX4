using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    // 1. Hàm tìm số lớn nhất trong 3 số
    static int FindLargestOfThree(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    // 1 (nâng cấp). Hàm nhận ít nhất 1 tham số (dùng params - varArg)
    static int FindLargest(params int[] numbers)
    {
        if (numbers.Length == 0)
            throw new ArgumentException("At least one number required");
        return numbers.Max();
    }

    // 2. Hàm tính giai thừa (factorial)
    static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Number must be non-negative");
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // 3. Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // 4.1. In tất cả số nguyên tố nhỏ hơn N
    static void PrintPrimesLessThanN(int n)
    {
        Console.WriteLine($"Prime numbers less than {n}:");
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // 4.2. In N số nguyên tố đầu tiên
    static void PrintFirstNPrimes(int n)
    {
        Console.WriteLine($"First {n} prime numbers:");
        int count = 0, number = 2;
        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
                count++;
            }
            number++;
        }
        Console.WriteLine();
    }

    // 5. Kiểm tra số hoàn hảo
    static bool IsPerfect(int n)
    {
        if (n < 2) return false;
        int sum = 1;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum == n;
    }

    static void PrintPerfectNumbersLessThan1000()
    {
        Console.WriteLine("Perfect numbers less than 1000:");
        for (int i = 2; i < 1000; i++)
        {
            if (IsPerfect(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // 6. Kiểm tra pangram
    static bool IsPangram(string input)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        input = input.ToLower();
        return alphabet.All(c => input.Contains(c));
    }

    // Test các hàm
    static void Main(string[] args)
    {
        Console.WriteLine("Largest of 3 numbers (10, 25, 15): " + FindLargestOfThree(10, 25, 15));
        Console.WriteLine("Largest using varArgs (5, 17, 3, 29, 12): " + FindLargest(5, 17, 3, 29, 12));

        Console.WriteLine("Factorial of 5: " + Factorial(5));

        Console.WriteLine("Is 29 prime? " + IsPrime(29));
        Console.WriteLine("Is 30 prime? " + IsPrime(30));

        PrintPrimesLessThanN(50);
        PrintFirstNPrimes(10);

        PrintPerfectNumbersLessThan1000();

        Console.WriteLine("Is pangram? " + IsPangram("The quick brown fox jumps over the lazy dog"));
    }
}
