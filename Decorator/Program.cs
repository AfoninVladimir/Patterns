using System;

    class Program
    {
        static void Main()
        {
        Client client = new Client();

        var berry = new Strawberry();
        Console.Write("Клиент получает обычную ягоду: ");
        client.ClientCode(berry);
        Console.WriteLine();

        Console.Write("Украшаем ");
        client.ClientCode(berry);
        
        Chocolate chocolate = new Chocolate(berry);
        Caramel caramel = new Caramel(berry);
        Caramel caramelchocolate = new Caramel(chocolate);
        Console.WriteLine("Теперь у клиента есть украшенная ягода:");
        client.ClientCode(chocolate);
        client.ClientCode(caramelchocolate);
        }
    }