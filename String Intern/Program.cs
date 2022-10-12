using System;
using System.Timers;
using System.Text;

namespace Testing
{
    internal class Program
    {
        static void Main()
        {
            string s1 = "TestingTesting";
            string s2 = new StringBuilder().Append("Testing").Append("Testing").ToString();
            string s3 = string.Intern(s2);

            DateTime start = DateTime.Now;
            for (long i = 0; i < 10000000; i++)
            {
                if (s3 == s1)
                    continue;
            }
            DateTime end = DateTime.Now;
            Console.WriteLine($"s3 == s1: {end - start}");

            start = DateTime.Now;
            for (long i = 0; i < 10000000; i++)
            {
                if (s3 == string.IsInterned(s1))
                    continue;
            }
            end = DateTime.Now;
            Console.WriteLine($"s3 == s1 intern: {end - start}");
        }
    }
}