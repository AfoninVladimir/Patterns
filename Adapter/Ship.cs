using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IWater
{
    void Sail();
}
class Ship : IWater
{
    public void Sail()
    {
        Console.WriteLine("Транспорт движется по воде");
    }
}