using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Директор отвечает только за выполнение шагов построения в определённой
// последовательности. 
public class Director
{    public IBuilder Builder
    {
        set { builder = value; }
    }

    private IBuilder builder;
    public void BuildMinimal()
    {
        this.builder.BuildPartB1();
        this.builder.BuildPartC1();
    }
    public void BuildFull()
    {
        this.builder.BuildPartA();
        this.builder.BuildPartB2();
        this.builder.BuildPartC2();
    }
}
