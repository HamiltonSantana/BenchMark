using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Entities;

namespace Clients
{
    public class RestCQRSClient
    {
        private readonly HttpClient client = new HttpClient();
    
        public async Task<Customer> GetPayloadAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicaion/json"));
            var url = $"https://localhost:7234/customers?Id=EC398896-53CC-4056-97E2-D9ED1AB8906F";
            var result = await client.GetFromJsonAsync<ResponseContent>(url);
            return result.Customer;
        }
    }
}