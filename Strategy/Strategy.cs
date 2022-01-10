using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Контекст определяет интерфейс, представляющий интерес для клиентов.
class Strategy
{
    // Контекст хранит ссылку на один из объектов Стратегии. Контекст не
    // знает конкретного класса стратегии. Он должен работать со всеми
    // стратегиями через интерфейс Стратегии.
    private IStrategy strategy;

    public Strategy()
    { }

    // Обычно Контекст принимает стратегию через конструктор, а также
    // предоставляет сеттер для её изменения во время выполнения.
    public Strategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    // Обычно Контекст позволяет заменить объект Стратегии во время выполнения.
    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    // Вместо того, чтобы самостоятельно реализовывать множественные версии
    // алгоритма, Контекст делегирует некоторую работу объекту Стратегии.
    public void DoSomeBusinessLogic(Book [] books)
    {
        Console.WriteLine("Результат сортировки:");
        this.strategy.Algorithm(books);     
    }
}