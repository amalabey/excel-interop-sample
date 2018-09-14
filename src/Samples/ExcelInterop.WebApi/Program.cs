using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterop.WebApi
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Running web-api sample..");

            List<Todo> todos = GetTodos().Result;

            Console.WriteLine("Finished! - "+todos.Count());
            Console.Read();
        }

        private static async Task<List<Todo>> GetTodos()
        {
            var jsonTask = client.GetStreamAsync("https://jsonplaceholder.typicode.com/todos");
 
            var serializer = new DataContractJsonSerializer(typeof(List<Todo>));
            var todos = serializer.ReadObject(await jsonTask) as List<Todo>;
            return todos;
        }
    }
}
