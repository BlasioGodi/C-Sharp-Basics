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
            Console.WriteLine("Linear Search took "+(endTime - startTime) );
        }

        ///<order>O(n^2)</order>
        public void BinarySearch()
        {

        }
        ///<order>O(n)</order>

        ///<order>O(n)</order>

        ///<order>O(n)</order>

        public void generateRandomArray()
        {
            Random randomNumbers = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                theArray[i] = randomNumbers.Next(1,arraySize );
            }
            itemsInArray = arraySize - 1;

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(theArray[i]);
            }
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



            if (System.Diagnostics.Debugger.IsAttached) Console.Read();

        }
    }
}