﻿using System;
using CorePlayground.LeedCodeL1;

namespace CorePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EasyQuestions
            //Console.WriteLine("Hello World!");
            //EasyQuestion es = new EasyQuestion();
            //Console.WriteLine("Enter String");
            //string inputString = Console.ReadLine();
            //Console.WriteLine(es.ReverseStringAndWords(inputString));
            //Console.WriteLine("Enter String");
            //string inputWord = Console.ReadLine();
            //Console.WriteLine(es.ReverseStringNotWords(inputWord));
            //Console.WriteLine("Enter String");
            //string inputWord = Console.ReadLine();
            //Console.WriteLine(es.ReverseWord(inputWord));
            //Console.WriteLine("Enter String");
            //string logicalReverseString = Console.ReadLine();
            //Console.WriteLine(es.ReverseStringNotWordLogically(logicalReverseString));
            //Console.WriteLine("Enter String");
            //string stringWordToReverse = Console.ReadLine();
            //Console.WriteLine(es.ReverseStringAndWordsLogically(stringWordToReverse));
            //Console.WriteLine("Enter String");
            //string stringToCount = Console.ReadLine();
            //es.CountWord(stringToCount);
            #endregion

            //FindPivotIndex.GrabPivotIndex(new int[] { 1,7,3,6,5,6 });
            //IsomorphicStrings.IsIsomorphic("badc", "baba");
            //Subsequence.IsSubsequence("b", "abc");
            ListNode list1 = new ListNode(1, null);
            list1.next = new ListNode(2, null);
            list1.next.next = new ListNode(4, null);

            ListNode list2 = new ListNode(1, null);
            list2.next = new ListNode( 3, null);
            list2.next.next = new ListNode(4, null);

            MergeTwoSortedList.MergeTwoLists(list1, list2);
        }
    }
}