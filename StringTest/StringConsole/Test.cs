using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringConsole
{
    public class Test
    {
        static int count;
        static string formart_one;
        static StringTemplate formart_two;
        static Test()
        {
            count = 10000;
            formart_one = "My name is {0}";
            formart_two =new StringTemplate("My name is ①",6);
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
