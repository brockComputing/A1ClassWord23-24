using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Assignment_done
{
    class Program
    {

        static void Main(string[] args)
        {
            int noInArray = HowManyNumbers();
            int[] originalArray = new int[noInArray];
            RandomTheArray(originalArray);
            DisplayTheArray(originalArray);
            string ans = "";
            do
            {
                Console.WriteLine("1. Set array size");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Bubble Sort Efficient");
                Console.WriteLine("4. Merge Sort");
                Console.WriteLine("9. Exit");
                ans = Console.ReadLine();
                switch (ans) //ans 
                {
                    case "1": // change size of the array          
                        Array.Resize(ref originalArray, HowManyNumbers());
                        RandomTheArray(originalArray);
                        DisplayTheArray(originalArray);
                        break;
                    case "2": // bubble sort
                        int[] bubArray = originalArray.Clone() as int[]; // cant pass arrays by value
                        BubbleSort(bubArray);
                        break;
                    case "3": // bubble sort efficent
                        int[] ebubArray = originalArray.Clone() as int[];
                        EfficientBubbleSort(ebubArray);
                        break;
                    case "4": // merge sort - this is second year stuff so dont worry about it
                        int[] mergeArray = originalArray.Clone() as int[];
                        MergeSort(mergeArray);
                        break;
                }

            } while (ans != "9");

        }
        static int HowManyNumbers()
        {
            int numbers = 0;
            bool ok = true;
            do
            {
                ok = true;
                try
                {
                    Console.WriteLine("Please enter how many numbers");
                    numbers = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You must only enter numbers");
                    ok = false;
                }
            } while (!ok);
            return numbers;
        }

        static void RandomTheArray(int[] theArray)
        {
            int lengthOfArray = theArray.Length;
            Random rnd = new Random();
            for (int i = 0; i < lengthOfArray; i++)
            {
                theArray[i] = rnd.Next(0, 1000); //random between 0 and 999
            }
        }

        static void DisplayTheArray(int[] theArray)
        {
            foreach (int element in theArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] bubbleArray)
        {
            Stopwatch timer = new Stopwatch();
            int lengthOfArray = bubbleArray.Length;
            int temp = 0;
            // get the start time
            timer.Start();
            // add your code here
            for (int passes = 0; passes < lengthOfArray - 1; passes++)
            {
                for (int i = 0; i < lengthOfArray - 1; i++)
                {
                    if (bubbleArray[i] > bubbleArray[i + 1])
                    {
                        //swap the items at i and i+1
                        temp = bubbleArray[i];
                        bubbleArray[i] = bubbleArray[i + 1];
                        bubbleArray[i + 1] = temp;
                    }
                }
            }
            timer.Stop();
            DisplayTheArray(bubbleArray);
            TimeSpan ts = timer.Elapsed;
            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime (minutes seconds milliseconds) " + elapsedTime);

        }

        static void EfficientBubbleSort(int[] bubbleArray)
        {
            Stopwatch timer = new Stopwatch();
            int lengthOfArray = bubbleArray.Length;
            int temp = 0;
            // get the start time
            timer.Start();
            // add your code here
            for (int passes = 0; passes < lengthOfArray - 1; passes++)
            {
                for (int i = 0; i < lengthOfArray - 1 - passes; i++)
                {
                    if (bubbleArray[i] > bubbleArray[i + 1])
                    {
                        //swap the items at i and i+1
                        temp = bubbleArray[i];
                        bubbleArray[i] = bubbleArray[i + 1];
                        bubbleArray[i + 1] = temp;
                    }
                }
            }
            timer.Stop();
            DisplayTheArray(bubbleArray);
            TimeSpan ts = timer.Elapsed;
            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime (minutes seconds milliseconds) " + elapsedTime);

        }

        private static void MergeSort(int[] mergeArray)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SortMerge(mergeArray, 0, mergeArray.Length - 1);
            timer.Stop();
            DisplayTheArray(mergeArray);
            TimeSpan ts = timer.Elapsed;
            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime (minutes seconds milliseconds) " + elapsedTime);
        }



        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {

            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }


        private static void SortMerge(int[] mergeArray, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(mergeArray, left, mid);
                SortMerge(mergeArray, (mid + 1), right);
                MainMerge(mergeArray, left, (mid + 1), right);
            }
        }
    }
}



