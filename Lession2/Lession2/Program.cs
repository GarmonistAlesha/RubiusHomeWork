using System.ComponentModel.Design;

 class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Определение високосного года");

        var year = Console.ReadLine();//введение значения 

        if (!uint.TryParse(year, out var value1)) // проверка на преобразование в положительное числовове значение
        {
            Console.WriteLine($"{year}- не валидное значение!!!");
            return;
        }
        if (value1 > 30000) // проверка максимального вводимого значения года
        {
            Console.WriteLine("Неверное условие.P.S Год больше 30000");
            return;
        }
        if (value1 % 4 == 0 || (value1 % 100 != 0 && value1 % 400 == 0))  // Условия високосного года 
        {
            Console.WriteLine("Yes");
            return;
           
        }
        else   //Условия не соответствия високосному году                                                                           //
        {
            Console.WriteLine("No");
            return;
        }
        
    }
}




















//ответ 