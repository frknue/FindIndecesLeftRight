using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static List<int> SummeKk(int[] numbers) {
        List<int> indeces = new List<int>();
        for (int i = 0; i < numbers.Length; i++) {
            int sumX = numbers.Take(i + 1).Sum();
            int sumY = numbers.Skip(i + 1).Sum();
            if (sumX == sumY) {
                indeces.Add(i);
            }
        }
        return indeces;
    }
    static void Main(string[] args) {
        Console.WriteLine("Please enter a quantity of numbers");
        string quantityString = Console.ReadLine();
        int quantity = 0;
        try {
            quantity = Convert.ToInt32(quantityString);
        } catch (FormatException) {
            throw new FormatException(quantityString + " is not a number");
        }
        int[] numbers = new int[quantity];
        for (int i = 0; i < quantity; i++) {
            if(i == 0) {
                Console.WriteLine("Please enter a number");
            } else {
                Console.WriteLine("Please enter another number");
            }
            string numberString = Console.ReadLine();
            try {
                numbers[i] = Convert.ToInt32(numberString);
            } catch (FormatException) {
                throw new FormatException("The number " + numberString + " is not a number");
            }
        }
        List<int> indeces = SummeKk(numbers);
        if (indeces.Count == 0) {
            Console.WriteLine("There is no index where the sum of the numbers before and after the index are equal");
        } else {
            Console.WriteLine("The indeces where the sum of the numbers before and after the index are equal are:");
            foreach (int index in indeces) {
                Console.WriteLine(index);
            }
        }
    }
}