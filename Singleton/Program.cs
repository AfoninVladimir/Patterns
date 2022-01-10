using System;
    class Program
    {
        static void Main()
        {
            Singleton x = Singleton.GetInstance();
            Singleton н = Singleton.GetInstance();

            if (x == н)
            {
                Console.WriteLine("Обе переменные содержат один и тот же экземпляр.");
            }
            else
            {
                Console.WriteLine("Переменные содержат разные экземпляры.");
            }
        }
    }