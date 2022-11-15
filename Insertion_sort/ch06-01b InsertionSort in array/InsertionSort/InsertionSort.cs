using System;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Sort(int[] a, int n)
        {
            int i, j, temp;
            for (i = 1; i < n; i++) // increasing loop
            {
                Console.ForegroundColor = ConsoleColor.White;
                temp = a[i];
                //Console.WriteLine("\ntemp = " + temp);
                // j >= 0 && is necessary to avoid indexoutofboundsexception
                for (j = i - 1; j >= 0 && a[j] > temp; j--)
                    a[j + 1] = a[j]; // move one to right if larger than temp
                a[j + 1] = temp;
                // show the current values
                for (int x = 0; x < a.Length; x++)
                {
                    if (x <= i) // sorted area
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (a[x] == temp)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(a[x] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
           }
            Console.WriteLine();
        }
        static int[] FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
                arr[x] = rand.Next(10, 99);
            return arr;
        }

        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n;
            char answer = 'y';
            Console.Write("Insertion sort sweeps from left to right. On the left is the sorted area. The sorted area grows with each sweep. The leftmost item from the unsorted area to the right moves into its proper place of the sorted area on the left. So, the values larger than the insertion item have to move one place to the right in the sorted area.\n\n");

            Console.Write("Enter the size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (answer == 'y' || answer == 'Y')
            {
                int[] a = new int[n];

                a = FillArray(a);

                Console.WriteLine("Original array is : ");
                ShowArray(a);

                //set breakpoint before call to sort to trace values
                Sort(a, n);

                Console.WriteLine("Sorted array is : ");
                ShowArray(a);

                Console.WriteLine("Another array to sort?");
                answer = Convert.ToChar(Console.ReadLine());

            }
        }

    }
}
