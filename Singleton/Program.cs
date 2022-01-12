using System;
    class Program
    {
        static void Main()
        {
            Singleton x = Singleton.GetInstance();
            Singleton y = Singleton.GetInstance();

            if (x == y)
            {
                Console.WriteLine("Обе переменные равны.");
            }
            else
            {
                Console.WriteLine("Переменные разные.");
            }
        }
    }