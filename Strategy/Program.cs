using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IStrategy
    {
        object Algorithm(object data);
    }

    class Program
    {
        static void Main()
        {
        Book [] books = new Book[11];
        books[0] = new Book("Евгений Замятин", "Мы", "Роман-антиутопия",8);
        books[1] = new Book("Джордж Оруэлл", "1984", "Роман-антиутопия",10);
        books[2] = new Book("Вячеслав Кумин", "Волчья стая", "Фантастика",7);
        books[3] = new Book("Рэй Брэдбери", "451 градус по Фаренгейту", "Роман-антиутопия",6);
        books[4] = new Book("Братья Стругацкие", "Пикник на обочине", "Научная фантастика",5);
        books[5] = new Book("Антуан де Сент-Экзюпери", "Маленький принц", "Сказка",9);
        books[6] = new Book("Дж. Р. Р. Толкин", "Хоббит или Туда и Обратно", "Фэнтези",1);
        books[7] = new Book("Дж. Р. Р. Толкин", "Властелин Колец.Братство Кольца", "Фэнтези",2);
        books[8] = new Book("Дж. Р. Р. Толкин", "Властелин Колец.Две Крепости", "Фэнтези",3);
        books[9] = new Book("Дж. Р. Р. Толкин", "Властелин Колец.Возвращение Короля", "Фэнтези",4);
        books[10] = new Book("Олдос Хаксли", "О дивный новый мир", "Роман-антиутопия",11);


        var strategy = new Strategy();

        Console.WriteLine("Группирование по жанрам");
        strategy.SetStrategy(new SortGenre());
        strategy.Logic(books);

        Console.WriteLine();

        Console.WriteLine("Группирование по aвторам");
        strategy.SetStrategy(new SortAutor());
        strategy.Logic(books);
        }
    }
