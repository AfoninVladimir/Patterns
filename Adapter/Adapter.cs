using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Adapter : ILand
{
    Ship ship;
    public Adapter(Ship s)
    {
        ship = s;
    }

    public void Drive()
    {
        ship.Sail();
    }
}
