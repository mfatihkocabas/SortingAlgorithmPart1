using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sortingList = { 51, 4, 145, 13, 45, 6, 13, 45, 56 };
            Console.WriteLine("---------Bubble Sort---------");
            BubbleSortedList(sortingList);
            Console.WriteLine("-------Insertion Sort------");
            InsertionSortedList(sortingList);
            Console.WriteLine("-------Selection Sort-------");
            SelectionSortedList(sortingList);
        }
        
        public static int[] InsertionSort(int[] sortingList)
        {
            for (int i = 1; i < sortingList.Length; ++i)
            {
                int keyElement = sortingList[i];
                
                while (i-1 >= 0 && sortingList[i-1] > keyElement)
                {
                   sortingList[i] = sortingList[i-1];
                    i = i - 1;
                }
                sortingList[i] = keyElement;
            }
            return sortingList;
        }

        public static int[] InsertionSortedList(int[] sortingList)
        {
            var sortedList = InsertionSort(sortingList);

            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.WriteLine($"{sortedList[i]}");
            }

            return sortedList;
        }


        public static int[] SelectionSort(int[] sortingList)
        {
            for (int i = 0; i < sortingList.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < sortingList.Length; j++)
                    if (sortingList[j] < sortingList[min_idx])
                        min_idx = j;
                (sortingList[min_idx], sortingList[i]) = (sortingList[i], sortingList[min_idx]);
            }
            return sortingList;
        }

        public static int[] SelectionSortedList(int[] sortingList)
        {
            var sortedList = SelectionSort(sortingList);

            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.WriteLine($"{sortedList[i]}");
            }

            return sortedList;
        }

        public static int[] BubbleSort(int[] sortingList)
        {
            int[] sortedList;

            for (int i = 0; i < sortingList.Length; i++)
            {
                for (int j = 0; j <sortingList.Length-1; j++)
                {
                    if (sortingList[j] >= sortingList[j + 1])
                    {
                        (sortingList[j], sortingList[j + 1]) = (sortingList[j + 1], sortingList[j]);
                    }
                }
                
            }
            sortedList = sortingList;
            return sortedList;
        }

        public static int[] BubbleSortedList(int[] sortingList)
        {
            var sortedList = BubbleSort(sortingList);

            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.WriteLine($"{sortedList[i]}");
            }

            return sortedList;
        }

    }
}
