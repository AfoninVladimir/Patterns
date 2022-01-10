using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        BMP3 bmp3 = new BMP3();
        Auto auto = new Auto();

        Console.WriteLine("Отправились в путь");
        bmp3.Move(auto);

        Console.WriteLine("Встретили на пути реку \n переход в плавающий режим");

        Ship ship = new Ship();
        ILand water = new Adapter(ship);

        bmp3.Move(water);

    }
}
