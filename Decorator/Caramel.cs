using System;

class Caramel : Decorator
{
    public Caramel(Berry berry) : base(berry) { }
    public override string Operation()
    {
        return $"{base.Operation()} в карамели";
    }
}
