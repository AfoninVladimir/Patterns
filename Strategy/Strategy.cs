using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Strategy
{
    private IStrategy strategy;
    public Strategy()
    { }
    public Strategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }
    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }
    public void DoSomeBusinessLogic(Book [] books)
    {
        Console.WriteLine("Результат сортировки:");
        this.strategy.Algorithm(books);     
    }
}