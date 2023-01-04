using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entities;

namespace Clients
{
    public class RestClient
    {
        private readonly HttpClient client = new HttpClient();
    
        public async Task<Customer> GetPayloadAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicaion/json"));
            var url = $"https://localhost:5001/Customer?id=EC398896-53CC-4056-97E2-D9ED1AB8906F";
            var result = await client.GetFromJsonAsync<ResponseContent>(url);
            return result.Customer;
        }
    }
}