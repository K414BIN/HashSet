using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {

         BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
         //   BechmarkClass.SearchHash();
         //   BechmarkClass.SearchString();
        }

    }
    
}
