// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using POC_BenchMark;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<BenchmarkDemo>();