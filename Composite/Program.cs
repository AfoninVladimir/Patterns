using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        Client client = new Client();

        // Таким образом, клиентский код может поддерживать простые
        // компоненты-листья...
        Leaf leaf = new Leaf();
        Console.WriteLine("Клиент: Я получаю простой компонент:");
        client.ClientCode(leaf);
        // ...а также сложные контейнеры.

        Composite box = new Composite();
        Composite branch1 = new Composite();
        Composite branch2 = new Composite();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        branch2.Add(new Leaf());
        box.Add(branch1);
        box.Add(branch2);

        Console.WriteLine("Клиент: Теперь у меня есть составное дерево:");
        client.ClientCode(box);


        Console.Write("Клиент: Мне не нужно проверять классы компонентов даже при управлении деревом:\n");
        client.ClientCode2(box, leaf);

        }
    }