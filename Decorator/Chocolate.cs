using System;
class Chocolate : Decorator
{
    public Chocolate(Berry berry) : base(berry)    {    }
    public override string Operation()
    {
        return $"{base.Operation()} в шоколаде";
    }
}
