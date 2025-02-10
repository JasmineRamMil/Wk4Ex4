using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex4
{
    internal class Program
    {
        class ArrayOperations
        {
            static void Main()
            {
                try
                {
                    // Step 1: Initialize the array with values from 1 to 10
                    int[] numbers = InitializeArray();

                    while (true)
                    {
                        try
                        {
                            // Display menu options
                            Console.WriteLine("\nArray Operations Menu:");
                            Console.WriteLine("1. Print all elements");
                            Console.WriteLine("2. Calculate sum of elements");
                            Console.WriteLine("3. Find maximum and minimum values");
                            Console.WriteLine("4. Reverse the array and print");
                            Console.WriteLine("5. Exit");

                            Console.Write("Enter your choice (1-5): ");
                            string choice = Console.ReadLine();

                            // Handle user choice with try-catch
                            switch (choice)
                            {
                                case "1":
                                    PrintArray(numbers);
                                    break;
                                case "2":
                                    Console.WriteLine($"Sum of all elements: {CalculateSum(numbers)}");
                                    break;
                                case "3":
                                    FindMinMax(numbers, out int min, out int max);
                                    Console.WriteLine($"Minimum Value: {min}");
                                    Console.WriteLine($"Maximum Value: {max}");
                                    break;
                                case "4":
                                    ReverseArray(numbers);
                                    Console.Write("Reversed Array: ");
                                    PrintArray(numbers);
                                    break;
                                case "5":
                                    Console.WriteLine("Exiting program. Goodbye!");
                                    return;
                                default:
                                    Console.WriteLine("Error: Invalid choice! Please enter a number between 1 and 5.");
                                    break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid input! Please enter a number between 1 and 5.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"A critical error occurred: {ex.Message}");
                }
            }

            // Method to initialize an array with values from 1 to 10
            static int[] InitializeArray()
            {
                int[] arr = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = i + 1;
                }
                return arr;
            }

            // Method to print all elements of the array
            static void PrintArray(int[] arr)
            {
                Console.Write("Array Elements: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }

            // Method to calculate the sum of all elements in the array
            static int CalculateSum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }

            // Method to find the maximum and minimum values in the array
            static void FindMinMax(int[] arr, out int min, out int max)
            {
                min = arr[0]; // Assume the first element is the minimum
                max = arr[0]; // Assume the first element is the maximum

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                    if (arr[i] > max)
                        max = arr[i];
                }
            }

            // Method to reverse the array manually (without built-in methods)
            static void ReverseArray(int[] arr)
            {
                int start = 0;
                int end = arr.Length - 1;

                while (start < end)
                {
                    // Swap elements
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;

                    // Move indices toward the center
                    start++;
                    end--;
                }
            }
        }

    }
}
