using Newtonsoft.Json;
using System;

namespace InventoryManagement1
{
    class Program
    {
        static void Main(string[] args)
        {
            fetchJsonforrice fetchJsonForRice = new fetchJsonforrice();

            var data = fetchJsonForRice.Read("E:/Json/Rice.json");

            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}
