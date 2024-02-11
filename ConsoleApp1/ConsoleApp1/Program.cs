
using System;
using System.Collections.Generic;

class Cafe
{
    public List<Visitor> Visitors { get; set; }

    public Cafe()
    {
        Visitors = new List<Visitor>();
    }

    public void AddVisitor(Visitor visitor)
    {
        Visitors.Add(visitor);
    }
}

class Visitor
{
    public string Name { get; set; }
    public Cafe Cafe { get; set; }

    public Visitor(string name, Cafe cafe)
    {
        Name = name;
        Cafe = cafe;
    }

    public void MakeOrder(string order)
    {
        Console.WriteLine($"{Name} делает заказ в кафе: {order}");
    }
}

// Пример использования классов
class Program
{
    static void Main()
    {
        // Создаем кафе
        Cafe cafe = new Cafe();

        // Создаем посетителей и добавляем их в кафе
        Visitor visitor1 = new Visitor("Анна", cafe);
        Visitor visitor2 = new Visitor("Иван", cafe);
        cafe.AddVisitor(visitor1);
        cafe.AddVisitor(visitor2);

        // Посетители делают заказы
        visitor1.MakeOrder("Кофе и круассан");
        visitor2.MakeOrder("Чай и тост");
    }
}
