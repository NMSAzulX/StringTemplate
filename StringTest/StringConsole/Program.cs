using System;
using System.Runtime.InteropServices;
using System.Text;

namespace StringConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///*
            string model = "My name is ①;";
            StringTemplate template = new StringTemplate(model,2,4);
            template.Max = 6;
            string result3 = template.Format("abcabc");
            Console.WriteLine(result3);

            template.Min = 1;
            result3 = template.Format("a");
            Console.WriteLine(result3);
            //Console.WriteLine(result2);
            //*/
            //BenchmarkDotNet.Running.BenchmarkRunner.Run<Test>();

            Console.ReadKey();

        }
    }
}
