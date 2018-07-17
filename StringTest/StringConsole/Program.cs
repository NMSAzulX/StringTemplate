using System;
using System.Runtime.InteropServices;
using System.Text;

namespace StringConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            string model = "My name is ①;";
            StringTemplate template = new StringTemplate(model);
            template.Max = 6;
            string result = template.Format("abc");
            //string result2 = template.Fill("abc");
            string result3 = template.Format("abcabc");
            Console.WriteLine(result);
            Console.WriteLine(result3);
            //Console.WriteLine(result2);
            */
            BenchmarkDotNet.Running.BenchmarkRunner.Run<Test>();
            
            Console.ReadKey();

        }
    }
}
