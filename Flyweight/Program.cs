using System;

class Program
{
    static void Main()
    {
        string type1 = "Разведчик";
        string type2 = "Штурмовик";
        string model1 = "T800";
        string model2 = "T1000";

        TerminatorFactory TerminatorFactory = new TerminatorFactory();

        Terminator T800Terminator = TerminatorFactory.GetTerminator("T800");
        T800Terminator.Build(type2, model1);



        Terminator T1000Terminator = TerminatorFactory.GetTerminator("T1000");
        T1000Terminator.Build(type1, model2);
    }
}

abstract class Terminator
{
    public abstract void Build(string type, string model);
}

class BuildTerminator : Terminator
{

    public override void Build(string type, string model)
    {
        Console.WriteLine("Построен терминатор модели: {0} тип: {1}", model, type);
    }
}

class TerminatorFactory
{
    Dictionary<string, Terminator> Terminators = new Dictionary<string, Terminator>();
    public TerminatorFactory()
    {
        Terminators.Add("T800", new BuildTerminator());
        Terminators.Add("T1000", new BuildTerminator());
    }

    public Terminator GetTerminator(string key)
    {
        return Terminators[key];
    }
}