using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System.Text;

namespace StringConsole
{
    [CoreJob]
    [MemoryDiagnoser]
    [InliningDiagnoser]
    [TailCallDiagnoser]
    public class Test
    {
        [Params(1000)]
        public int count;
        static string formart_one;
        static StringTemplate formart_two;
        static Test()
        {
            formart_one = "My name is {0}";
            formart_two =new StringTemplate("My name is ①",4);
        }
        [Benchmark]
        public void StringBuilder()
        {
            for (int i = 0; i < count; i += 1)
            {
                string result =new StringBuilder().Append("My name is ").Append(i).Append(";").ToString();
            }
        }
        [Benchmark]
        public void StringFormat()
        {
            for (int i = 0; i < count; i+=1)
            {
                string result = $"My name is {i};";
            }
        }
        [Benchmark]
        public void TemplateFormat()
        {
            for (int i = 0; i < count; i += 1)
            {
                string result = formart_two.Format(i.ToString());
            }
        }

        /*[Benchmark]
        public void TestTemplateCopy()
        {
            for (int i = 0; i < count; i += 1)
            {
                string result = formart_two.Fill(i.ToString());
            }
        }*/
    }
}
