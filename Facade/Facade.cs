using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Facade
{
    protected LifeSupportSystem subsystem1;

    protected PowerSupplySystem subsystem2;

    public Facade(LifeSupportSystem subsystem1, PowerSupplySystem subsystem2)
    {
        this.subsystem1 = subsystem1;
        this.subsystem2 = subsystem2;
    }

    public string Operation()
    {
        string result = "Инициализация подсистем:\n";
        result += this.subsystem1.CheckSystem();
        result += this.subsystem2.CheckSystem();
        result += "\nПодготовка систем к работе\n";
        result += this.subsystem1.PrepareSystem();
        result += this.subsystem2.PrepareSystem();
        result += "\nЗапус систем\n";
        result += this.subsystem1.StartSystem();
        result += this.subsystem2.StartSystem();
        return result;
    }
}
