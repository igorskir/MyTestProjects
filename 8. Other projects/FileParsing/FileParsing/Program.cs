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
            int i = 1;
            Console.WriteLine(++i);
            Console.WriteLine(i++);

            int x = 1;
            x = x + ++x;

            int y = 1;
            y = ++y + y;

            int z = 1;
            z = z++ + z;

            Console.WriteLine(x + " " + y + " " + z);
            //ParseMethodFirst(@"D:\data.txt", @"D:\res.txt");
            //FindeNextId(@"D:\ids.txt");
            //GetPostElements(@"D:\post.txt");
            Console.ReadLine();
        }

        static void ParseMethodFirst(string filePath, string results)
        {
            StreamReader reader = File.OpenText(filePath);
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

        static void FindeNextId(string filePath)
        {
            int id = 0;
            List<int> idsInts = new List<int>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                string[] items = line.Split(' ');
                int myId = int.Parse(items[0]);
                idsInts.Add(myId);
            }

            for (int i = 1; i < idsInts.Count; i++)
            {

                if (idsInts[i] - idsInts[i - 1] != 1)
                {
                    Console.WriteLine("Id в списке идентификаторов находятся не в порядке увеления на 1");
                    Console.WriteLine("Ошибка возникла между Id={0} и Id={1}", idsInts[i], idsInts[i - 1]);
                    break;
                }
            }

            int maxId = idsInts.Max();
            id = maxId + 1;
            Console.WriteLine("Максимальный найденный Id = {0}", maxId);
            Console.WriteLine("Следующий Id = {0}", id);

        }

        
        static void GetPostElements(string filePath)
        {
            List<Post> posts = new List<Post>();

            StreamReader reader = File.OpenText(filePath);
            string line;
            List<int> numbers = new List<int>();
            List<string> pathes = new List<string>();

            string[] item = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = item[i].Trim('\r');
            }

            Post p1 = new Post();
            p1.id = 10;
            p1.name = "qwe";
            p1.sername = "qweqwe";
            for (int i = 0; i < item.Length; i+=3)
            {
                posts.Add(new Post() { id = int.Parse(item[i]), name = item[i+1], sername = item[i+2] });
            }

            foreach (var var in posts)
            {
                Console.WriteLine(var.id + " " + var.name + " " + var.sername);
            }
            //while ((line = reader.ReadToEnd()) != null)
            //{

            //    string[] items = line.Split('\n');
            //    int myInt = int.Parse(items[1]);
            //    numbers.Add(myInt);
            //    foreach (var item in items)
            //    {
            //        if (item.StartsWith(@"item\") && item.EndsWith(@".ddj"))
            //            pathes.Add(item);
            //    }
            //}

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
    struct Post
    {
        public int id;
        public string name;
        public string sername;
    }
}
