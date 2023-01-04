using System;
using BenchmarkDotNet.Attributes;
using Clients;

namespace POC_BenchMark
{
    // [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        [Params(100, 200, 500, 1000)]
        public int IterationCount;
        private readonly RestCQRSClient _restCQRSClient = new RestCQRSClient();
        private readonly RestClient _restClient = new RestClient();
        [Benchmark]
        public async Task RestGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _restClient.GetPayloadAsync();
            }
        }
        [Benchmark]
        public async Task RestCQRSGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _restCQRSClient.GetPayloadAsync();
            }
        }
    }
}