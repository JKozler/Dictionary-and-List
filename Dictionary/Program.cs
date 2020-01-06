using System;
using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Read(s);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Chceš vidět jejich pozice v souboru? <ano/ne>: ");
            if (Console.ReadLine() == "ano")
            {
                ZjistiPozice(s);
            }
            else { Console.WriteLine("Tak čus..."); }

            Console.ReadKey();
        }

        public static void Read(string path)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(path))
            {
                string ovoce;
                while ((ovoce = sr.ReadLine()) != null)
                {
                    if (d.ContainsKey(ovoce))
                    {
                        d[ovoce] += 1;
                    }
                    else
                    {
                        d.Add(ovoce, 1);
                    }
                }
            }
            Console.WriteLine("Slovo                     abs. četnost                      rel. četnost");
            Console.WriteLine("========================================================================");
            foreach (KeyValuePair<string, int> da in d)
            {
            Console.WriteLine("{0}                       {1}                               {2}",da.Key, da.Value, Convert.ToDouble(da.Value) / Convert.ToDouble(da.Key.Length));
            }
        }

        public static void ZjistiPozice(string path)
        {
            Dictionary<string, List<int>> di = new Dictionary<string, List<int>>();
            using (StreamReader sr = new StreamReader(path))
            {
                string ovoce;
                while ((ovoce = sr.ReadLine()) != null)
                {
                    int i = 0;
                    if (di.ContainsKey(ovoce))
                    {
                        di[ovoce] = new List<int>();
                        di[ovoce].Add(i);
                        i++;
                    }
                    else
                    {
                        di.Add(ovoce, new List<int>());
                        di[ovoce].Add(i);
                        i++;
                    }
                }
            }
            foreach (KeyValuePair<string, List<int>> item in di)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
        }
    }
}
