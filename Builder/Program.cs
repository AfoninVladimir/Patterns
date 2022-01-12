using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
            // Ккод создаёт объект-строитель, передаёт его директору,
            // а затем инициирует  процесс построения. 
            var director = new Director();
            var builder = new Builder();
            director.Builder = builder;

            Console.WriteLine("Минимальная комплектация:");
            director.BuildMinimal();
            Console.WriteLine(builder.GetTerminator().ListParts());

            Console.WriteLine("Полная комплектация:");
            director.BuildFull();
            Console.WriteLine(builder.GetTerminator().ListParts());

            Console.WriteLine("Индивидуальная комплектация:");
            builder.BuildPartA();
            builder.BuildPartB2();
            builder.BuildPartC1();
            Console.Write(builder.GetTerminator().ListParts());
        }
    }