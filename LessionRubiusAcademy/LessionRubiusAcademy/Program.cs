
namespace Lesson6
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> intStack = new Stack<int>();
            intStack.Push(0);
            intStack.Push(5);
            Console.WriteLine($"Стек Stack<int> пуст? {intStack.IsEmpty()}");
            Console.WriteLine($"Верхний элемент Stack<int>: {intStack.Peek()}");
            Console.WriteLine($"Удален элемент из Stack<int>: {intStack.Pop()}"); 
            

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("New");
            stringStack.Push("Class");
            Console.WriteLine($"Стек Stack<string> пустой? {stringStack.IsEmpty()}");
            Console.WriteLine($"Верхний элемент Stack<string>: {stringStack.Peek()}");
            stringStack.Clear();
            
  
            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(0.35);
            doubleStack.Push(0.84);
            Console.WriteLine($"Стек Stack<double> пустой? {doubleStack.IsEmpty()}");
            Console.WriteLine($"Верхний элемент Stack<double>: {doubleStack.Peek()}");
            Console.WriteLine($"Удален элемент из Stack<double>: {doubleStack.Pop()}");
            
        }
    }
}