using System;
// проверка систем на станции колонистов в далёком космосе
    class Program
    {
        static void Main()
        {
        LifeSupportSystem subsystem1 = new LifeSupportSystem();
        PowerSupplySystem subsystem2 = new PowerSupplySystem();
            Facade facade = new Facade(subsystem1, subsystem2);
        User.UserCode(facade);
        }
    }
