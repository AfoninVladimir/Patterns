using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Фабрика создания бегущего героя с мечом
class Spearman : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new RideHorse();
    }

    public override Weapon CreateWeapon()
    {
        return new Spear();
    }
}
