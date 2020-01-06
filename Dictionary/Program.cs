﻿using System;
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
            foreach (KeyValuePair<string, int> da in d)
            {
                Console.WriteLine("Slovo: {0}, abs. čtenost: {1}, rel. četnost: {2}",da.Key, da.Value, Convert.ToDouble(da.Value) / Convert.ToDouble(da.Key.Length));
            }
        }

        public static void ZjistiPozice(string path)
        {
            List<string> l = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {

            }
        }
    }
}