using System;
using System.Collections;
using System.Collections.Generic;

namespace NET.S._2020.Aristova._06
{
    public class SortMethods 
    {

        //public void SortByAmount(Dictionary<int, int> rowDictionary)
        //{
           
        //    for (int rowIndex = 0; rowIndex < Array.Length - 1; rowIndex++)
        //    {
        //        for (int i = 0; i < Array.Length - rowIndex - 1; i++)
        //        {
        //            if (rowDictionary[i] < rowDictionary[i + 1])
        //            {
        //                //swap dictionary value
        //                int temp = rowDictionary[i];
        //                rowDictionary[i] = rowDictionary[i + 1];
        //                rowDictionary[i + 1] = temp;

        //                //swap row in Array
        //                int[] arr = Array[i];
        //                Array[i] = Array[i + 1];
        //                Array[i + 1] = Array[i];
        //            }
        //        }
        //    }
        //}

        //private Dictionary<int, int> CreateDictionaryRowSum()
        //{
        //    Dictionary<int, int> dictionaryRowSummary = new Dictionary<int, int>();
        //    int sum = 0;
        //    for (int rowIndex = 0; rowIndex < Array.Length; rowIndex++)
        //    {
        //        for (int columnIndex = 0; columnIndex < Array[rowIndex].Length; columnIndex++)
        //        {
        //            sum += Array[rowIndex][columnIndex];
        //        }
        //        dictionaryRowSummary.Add(rowIndex, sum);
        //        sum = 0;
        //    }

        //    return dictionaryRowSummary;
        //}

        //private Dictionary<int, int> CreateDictionaryMaxElementsInRow()
        //{
        //    Dictionary<int, int> dictionaryMaxElementsInRow = new Dictionary<int, int>();
        //    int max;
        //    for (int rowIndex = 0; rowIndex < Array.Length; rowIndex++)
        //    {
        //        max = Int32.MinValue;
                
        //        for (int columnIndex = 0; columnIndex < Array[rowIndex].Length; columnIndex++)
        //        {
        //            if (max < Array[rowIndex][columnIndex])
        //            {
        //                max = Array[rowIndex][columnIndex];
        //            }
        //        }
        //        dictionaryMaxElementsInRow.Add(rowIndex, max);
        //    }

        //    return dictionaryMaxElementsInRow;
        //}

        //private Dictionary<int, int> CreateDictionaryMinElementsInRow()
        //{
        //    Dictionary<int, int> dictionaryMinElementsInRow = new Dictionary<int, int>();
            
        //    for (int rowIndex = 0; rowIndex < Array.Length; rowIndex++)
        //    {
        //        int minValue = Int32.MaxValue;

        //        for (int columnIndex = 0; columnIndex < Array[rowIndex].Length; columnIndex++)
        //        {
        //            if (minValue > Array[rowIndex][columnIndex])
        //            {
        //                minValue = Array[rowIndex][columnIndex];
        //            }
        //        }
        //        dictionaryMinElementsInRow.Add(rowIndex, minValue);
        //    }

        //    return dictionaryMinElementsInRow;
        //}

        private static void BubbleSort(int[][] array, IComparer comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        int[] temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }


        public static void BubbleSortBySummary(int[][] array)
        {
            SumComparer sumComparer = new SumComparer();
            BubbleSort(array, sumComparer);
        }


        public static void BubbleSortByMaxElement(int[][] array)
        {
            MaxElementComparer maxElementComparer = new MaxElementComparer();
            BubbleSort(array, maxElementComparer);
        }

        public static void BubbleSortByMinElement(int[][] arraay)
        {
            MinElementComparer minElementComparer = new MinElementComparer();
            BubbleSort(arraay, minElementComparer);
        }
        

        
    }


    public class SumComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int[] array1 =(int[]) x;
            int[] array2 = (int[]) y;

            int sum1 = 0;
            int sum2 = 0;

            int result = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }

            if (sum1 > sum2)
            {
                result = 1;
            }

            return result;

        }
    }


    public class MaxElementComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int[] array1 = (int[])x;
            int[] array2 = (int[])y;

            int max1 = 0;
            int max2 = 0;

            int result = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (max1 < array1[i])
                {
                    max1 = array1[i];
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (max2 < array2[i])
                {
                    max2 = array2[i];
                }
            }

            if (max1 > max2)
            {
                result = 1;
            }

            return result;
        }
    }


    public class MinElementComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int[] array1 = (int[])x;
            int[] array2 = (int[])y;

            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;

            int result = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (min1 > array1[i])
                {
                    min1 = array1[i];
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (min2 > array2[i])
                {
                    min2 = array2[i];
                }
            }

            if (min1 < min2)
            {
                result = 1;
            }

            return result;
        }
    }
    
}