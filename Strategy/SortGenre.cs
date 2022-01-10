﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortGenre : IStrategy
{
    public object Algorithm(object data)
    {
        var book = from i in data as Book[]
                   group i by i.Genre;
        foreach (var items in book)
        {
            Console.WriteLine();
            Console.WriteLine($"{items.Key}:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Autor} - \"{item.Name}\"");
            }
        }
        return book;
    }
}