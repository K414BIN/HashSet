using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HashSet
{
    public class BechmarkClass
    {
        public static     int SizeOfData = 10000;
        public static     int SingleStringSize = 20;
        public static string[] StringArray = new string[SizeOfData];
        public static string[] symbolList = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
                                            "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                                            "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g",
                                            "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r",
                                            "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2",
                                                                "3", "4", "5", "6", "7", "8", "9" };
        public static int len = symbolList.Length - 1;
        public static HashSet<string> hashSet = new HashSet<string>();
        public static string value = prepare();
        public static string prepare()
        {
            Random rand = new Random();

            for (int j = 0; j<SizeOfData;j++ )
            {
               
                for ( int i =0; i<SingleStringSize;i++)
                {
                    StringArray[j] = StringArray[j] + symbolList[ rand.Next(len)];
                }
                hashSet.Add(StringArray[j]);
            }
            return StringArray[rand.Next(Math.Abs(SizeOfData-1))];
        }

        [Benchmark(Description = "Search for a string in an array of strings ")]
        public  void SearchString()
        {
            
            for (int i = 0; i < SizeOfData; i++)
            {
                if (value == StringArray[i]) { };
                
            }
        }

        [Benchmark(Description = "Search for a string in a hashSet ")]
        public  void SearchHash()
        {
          hashSet.Contains(value);
        }

    }
}
