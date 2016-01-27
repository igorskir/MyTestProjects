using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseMethodFirst(@"D:\data.txt", @"D:\res.txt");

            Console.ReadLine();
        }

        static void ParseMethodFirst(string filePath, string results)
        {
            StreamReader reader = File.OpenText(filePath);
            string text = File.ReadAllText(filePath);
            string line;
            List<int> numbers = new List<int>();
            List<string> pathes = new List<string>();
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split('\t');
                int myInt = int.Parse(items[1]);
                numbers.Add(myInt);
                foreach (var item in items)
                {
                    if (item.StartsWith(@"item\") && item.EndsWith(@".ddj"))
                        pathes.Add(item);
                }
            }

            foreach (var a in numbers) { Console.Write(a + " "); }

            Console.WriteLine();

            foreach (var path in pathes) { Console.WriteLine(path); }
        }
        static void ParseMethodSecond(string filePath, string results)
        {
            
            List<int> numbers = new List<int>();
            List<string> pathes = new List<string>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                string[] items = line.Split('\t');
                int myInt = int.Parse(items[1]);
                numbers.Add(myInt);
                pathes.AddRange(items.Where(item => item.StartsWith(@"item\") && item.EndsWith(@".ddj")));
            }

            File.WriteAllLines(results, pathes.ToArray());

            foreach (var a in numbers) { Console.Write(a + " "); }

            Console.WriteLine();

            foreach (var path in pathes) { Console.WriteLine(path); }
        }
    }
}
