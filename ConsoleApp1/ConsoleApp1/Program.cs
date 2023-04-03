using Newtonsoft.Json;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            HttpClient client = new HttpClient();

            try
            {
                //GET: GetAsync sends GET request to the specified URI as an asynchronous operation
                var httpRespondMessage = await client.GetAsync(url);
                string jsonResponse = await httpRespondMessage.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);

                //DESERIALIZE json string into Post objects
                var jsonPost = JsonConvert.DeserializeObject<Post[]>(jsonResponse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally { client.Dispose(); }
        }
    }
    
}