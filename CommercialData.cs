using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement1
{
    class CommercialData
    {
        static void calculateSpan(int[] price,int n, int[] S)
        {

            // Span value of first day is always 1
            S[0] = 1;

            // Calculate span value of remaining
            // days by linearly checking previous
            // days
            for (int i = 1; i < n; i++)
            {
                S[i] = 1; // Initialize span value

                // Traverse left while the next
                // element on left is smaller
                // than price[i]
                for (int j = i - 1; (j >= 0) && (price[i] >= price[j]); j--)
                    S[i]++;
            }
        }

        // A utility function to print elements
        // of array
        static void printArray(int[] arr)
        {
            string result = string.Join(" ", arr);
            Console.WriteLine(result);
        }

        // Driver function
        public static void Main()
        {
            int[] price = { 10, 4, 5, 90, 120, 80 };
            int n = price.Length;
            int[] S = new int[n];

            // Fill the span values in array S[]
            calculateSpan(price, n, S);

            // print the calculated span values
            printArray(S);
        }
    }
}

