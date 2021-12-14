using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Систсема энергоснабжения
public class PowerSupplySystem
{
    public string CheckSystem()
    {
        return "Систсема энергоснабжения: Исправна\n";
    }

    public string PrepareSystem()
    {
        return "Систсема энергоснабжения: Подготовка к запуску\n";
    }

    public string StartSystem()
    {
        return "Систсема энергоснабжения: Подача энергии на компоненты базы возобновлена\n";
    }
}

