using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace cs_jsonquery
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = File.ReadAllText("data.json");
            JObject js = JObject.Parse(txt);
            Console.WriteLine(js["header"]["id"]);
        }
    }
}
