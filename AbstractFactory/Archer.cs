using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Фабрика создания летящего героя с арбалетом
class Archer : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new Run();
    }

    public override Weapon CreateWeapon()
    {
        return new Bow();
    }
}
