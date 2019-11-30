using BenchmarkDotNet.Running;
using RomanNumeralsConverter;
using System;

namespace RomanNumeralsConverterBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<RomanNumeralsConverter.RomanNumeralsConverterBenchmarks>();
        }
    }
}
