using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBuilder
{
    void BuildPartA();

    void BuildPartB1();
    void BuildPartB2();

    void BuildPartC1();
    void BuildPartC2();

}

public class Builder : IBuilder
{
    private Terminator terminator = new Terminator();


    public Builder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this.terminator = new Terminator();
    }

    public void BuildPartA()
    {
        this.terminator.Add("Кожный покров");
    }

    public void BuildPartB1()
    {
        this.terminator.Add("Титановый эндоскелет");
    }

    public void BuildPartB2()
    {
        this.terminator.Add("Эндоскелет из сплава титана и вольфрама");
    }

    public void BuildPartC1()
    {
        this.terminator.Add("Миниатюрная реакторная установка");
    }

    public void BuildPartC2()
    {
        this.terminator.Add("2 водородных топливных элемента");
    }


    public Terminator GetTerminator()
    {
        Terminator result = this.terminator;

        this.Reset();

        return result;
    }
}
