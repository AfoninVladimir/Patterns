using System;
    class Program
    {
        static void Main()
        {
            Singleton x1 = Singleton.GetInstance();
            Singleton x2 = Singleton.GetInstance();

            if (x1 == x2)
            {
                Console.WriteLine("Синглтон работает, обе переменные содержат один и тот же экземпляр.");
            }
            else
            {
                Console.WriteLine("Одноэлементный сбой, переменные содержат разные экземпляры.");
            }
        }
    }