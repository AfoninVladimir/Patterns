using System;

abstract class Decorator : Berry
{
    protected Berry berry;
    public Decorator(Berry berry)
    {
        this.berry = berry;
    }
    public void SetComponent(Berry berry)
    {
        this.berry = berry;
    }
    public override string Operation()
    {
        return this.berry.Operation();
    }
}
