using System;
using System.IO;
using Newtonsoft.Json;
namespace AlgorithmiaPipe
{    public class Write
    {
        private static string OutputPath = "/tmp/algoout";

        public static void WriteJsonToPipe(object response)
        {
            Console.Out.Flush();
            string serialized = JsonConvert.SerializeObject(response);
            using (StreamWriter w = new StreamWriter(OutputPath, true))
            {
                w.Write(serialized);
                w.Write("\n");
            }
        }
    }
}