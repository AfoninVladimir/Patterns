using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу Cтратегии.
// Этот интерфейс делает их взаимозаменяемыми в Контексте.
class SortAutor : IStrategy
{
    public object Algorithm(object data)
    {
        var book = from i in data as Book[]
                  group i by i.Autor;
        foreach (var items in book)
        {
            Console.WriteLine();
            Console.WriteLine($"{items.Key}: ");
            foreach (var item in items)
            {
                Console.WriteLine($"\"{item.Name}\"");
            }
        }
        return book;
    }
}