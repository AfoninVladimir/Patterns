class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Класс: Лучник");
        Hero archer = new Hero(new Archer());
        Console.Write("Владение: ");
        archer.Mastery();
        Console.Write("Способ передвижения: ");
        archer.Run();

        Console.WriteLine("\nКласс: Всадник");
        Hero rider = new Hero(new Spearman());
        Console.Write("Владение: ");
        rider.Mastery();
        Console.Write("Способ передвижения: ");
        rider.Run();

        Console.ReadLine();
    }
}