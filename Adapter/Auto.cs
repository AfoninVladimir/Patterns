using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ILand
{
    void Drive();
}
class Auto : ILand
{
    public void Drive()
    {
        Console.WriteLine("Транспорт движется оп суше");
    }
}