using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"c:\temp\file1.txt";
            string TargePath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(SourcePath);

                using (StreamWriter sw = File.AppendText(TargePath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
