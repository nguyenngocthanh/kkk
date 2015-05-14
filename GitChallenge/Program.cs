﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            _randomizedNames = DoRandomizeList(GetNames());
            _randomizedNickNames = DoRandomizeList(GetNickNames());

            foreach ( var name in _randomizedNames)
            {
                foreach (var nickName in _randomizedNickNames)
                {
                    if(name.Key == nickName.Key)
                    {
                        Console.WriteLine(string.Format("Name: '{0}' has nickname '{1}' ", name.Value, nickName.Value));
                    }
                }
            }

            Console.ReadKey();
        }


        private static IList<KeyValuePair<int, string>> _randomizedNames { get; set; }
        private static IList<KeyValuePair<int, string>> _randomizedNickNames { get; set; }



        private static IList<string> GetNames()
        {
            var names = new List<string>();

            names.Add("Khoa");
            names.Add("Khoa1");
            names.Add("Khoa2");
            names.Add("Khoa3");

            return names;
        }


        private static IList<string> GetNickNames()
        {
            var nickNames = new List<string>();
            nickNames.Add("My nickname");
            nickNames.Add("My nickname1");
            nickNames.Add("My nickname2");
            nickNames.Add("My nickname3");

            return nickNames;
        }


        private static IList<KeyValuePair<int, string>> DoRandomizeList(IList<string> list)
        {
            var result = new List<KeyValuePair<int, string>>();
            Random rand = new Random();

            var check = new HashSet<int>();
            foreach (var item in list)
            {

                int curValue = rand.Next(1, list.Count + 1);
                while (check.Contains(curValue))
                {
                    curValue = rand.Next(1, list.Count + 1);
                }
                result.Add(new KeyValuePair<int, string>(curValue, item));

                check.Add(curValue);
            }

            return result;
        }
    }
}
