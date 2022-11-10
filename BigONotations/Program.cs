using System;
using System.Collections.Generic;
using System.Data;

namespace TheBigONotations
{
    public class BigONotations
    {
        ///<properties>Class Properties</properties>
        private int[] theArray;
        private int arraySize;
        private int itemsInArray = 0;
        DateTime startTime;
        DateTime endTime;

        public BigONotations(int size)
        {
            arraySize = size;
            theArray = new int[size];
        }
        ///<Array>Random Array  Generator Function</Array>
        public void generateRandomArray()
        {
            Random randomNumbers = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                theArray[i] = randomNumbers.Next(1, arraySize);
            }
            itemsInArray = arraySize - 1;
        }
        ///<order>O(1)</order>
        public void addItemToArray(int newItem)
        {
            theArray[itemsInArray++] = newItem;
        }
        ///<order>O(n)</order>
        public void linearSearch(int value)
        {
            bool valueInArray = false;
            string indexsWithValue = "";

            startTime = DateTime.Now;
            int start = startTime.Millisecond;

            for (int i = 0; i < arraySize; i++)
            {
                if (theArray[i] == value)
                {
                    valueInArray = true;
                    indexsWithValue += i + " ";
                }
            }
            Console.WriteLine("Value found: " + valueInArray);

            endTime = DateTime.Now;
            int end = endTime.Millisecond;

            Console.WriteLine("Linear Search took "+(end - start) );
        }

        ///<order>O(n^2)</order>
        public void BubbleSort()
        {
            startTime = DateTime.Now;
            int start = startTime.Millisecond;

            //for (int i = arraySize-1; i > 1; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (theArray[j] > theArray[j + 1])
            //        {
            //            //var temp = theArray[j];
            //            //theArray[j] = theArray[j + 1];
            //            //theArray[j + 1] = temp;
            //        }
            //    }
            //}

            endTime = DateTime.Now;
            int end = endTime.Millisecond;
            Console.WriteLine("Bubble Sort took " + (end - start));
        }
        ///<order>O(log n)</order>
        public void BinarySearch(int value)
        {
            startTime = DateTime.Now;
            int start = startTime.Millisecond;

            int lowIndex = 0;
            int highIndex = arraySize - 1;

            int timesThrough = 0;

            while (lowIndex <= highIndex)
            {
                int middleIndex = (highIndex + lowIndex) / 2;

                if (theArray[middleIndex] < value)
                    lowIndex = middleIndex + 1;
                else if (theArray[middleIndex] > value)
                    highIndex = middleIndex - 1;
                else
                {
                    Console.WriteLine("Found match in index " + middleIndex);
                    lowIndex = highIndex + 1;
                }
                timesThrough++;
            }

            endTime = DateTime.Now;
            int end = endTime.Millisecond;
            Console.WriteLine("Binary Search took " + (end - start));
            Console.WriteLine("TimesThrough " + timesThrough);
        }
        ///<order>O(n log n)</order>
        public void QuickSort(int left, int right)
        {
            if (right - left <= 0)
                return;
            else
            {
                int pivot = theArray[right];
                int pivotLocation = PartitionArray(left, right, pivot);
                
                QuickSort(left, pivotLocation - 1);
                QuickSort(pivotLocation + 1, right);
            }
        }

        public int PartitionArray(int left, int right, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (theArray[++leftPointer] < pivot)
                    ;
                while (rightPointer > 0 && theArray[--rightPointer] > pivot)
                    ;

                if (leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {
                    swapValues(leftPointer, rightPointer);

                }
            }
            swapValues(leftPointer, right);
            return leftPointer;
        }
        public static void Main()
        {

            BigONotations algoTest1 = new BigONotations(100000);
            algoTest1.generateRandomArray();

            BigONotations algoTest2 = new BigONotations(200000);
            algoTest2.generateRandomArray();

            BigONotations algoTest3 = new BigONotations(300000);
            algoTest3.generateRandomArray();

            BigONotations algoTest4 = new BigONotations(400000);
            algoTest4.generateRandomArray();

            BigONotations algoTest5 = new BigONotations(500000);
            algoTest5.generateRandomArray();

            algoTest2.linearSearch(20);
            algoTest3.linearSearch(20);
            algoTest4.linearSearch(20);

            algoTest2.BubbleSort();
            algoTest3.BubbleSort();
            algoTest4.BubbleSort();

            algoTest2.BinarySearch(20);
            algoTest3.BinarySearch(20);
            algoTest4.BinarySearch(20);

            if (System.Diagnostics.Debugger.IsAttached) Console.Read();

        }
    }
}