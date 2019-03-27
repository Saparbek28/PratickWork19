﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @" Вот дом,
                  Который построил Джек.
                  А это пшеница,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  А это веселая птица-синица,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  Вот кот,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  Вот пес без хвоста,
                  Который за шиворот треплет кота,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  А это корова безрогая,
                  Лягнувшая старого пса без хвоста,
                  Который за шиворот треплет кота,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  А это старушка, седая и строгая,
                  Которая доит корову безрогую,
                  Лягнувшую старого пса без хвоста,
                  Который за шиворот треплет кота,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  А это ленивый и толстый пастух,
                  Который бранится с коровницей строгою,
                  Которая доит корову безрогую,
                  Лягнувшую старого пса без хвоста,
                  Который за шиворот треплет кота,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.
                  Вот два петуха,
                  Которые будят того пастуха,
                  Который бранится с коровницей строгою,
                  Которая доит корову безрогую,
                  Лягнувшую старого пса без хвоста,
                  Который за шиворот треплет кота,
                  Который пугает и ловит синицу,
                  Которая часто ворует пшеницу,
                  Которая в темном чулане хранится
                  В доме,
                  Который построил Джек.";


            List<string> words = new List<string>(text.Replace(",", " ").Replace(".", " ").Replace("\r\r", "").Replace("\r\n", "").Split(' '));

            HashSet<string> uniqueWords = new HashSet<string>(words);
            uniqueWords.Remove("");
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            foreach (var item in uniqueWords)
            {
                countWords.Add(item, words.FindAll(x => x == item).Count);
            }
            int i = 0;
            Console.WriteLine("\t\tСлово:\t\tКол-во:");
            foreach (var item in countWords)
            {

                Console.WriteLine("{0,3} {1,15}\t{2,10}", ++i, item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}
