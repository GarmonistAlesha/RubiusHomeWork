using System;

namespace Lesson3RA;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Введите длину массива");                          //запросить у пользователя размер массива
        var value =Console.ReadLine();
        if (int.TryParse(value, out int value1))
        {

        }
        else                      
        {
            Console.WriteLine("Вам необходимо ввести число");                // Проверка корректного значения "Длинны массива" 
            return;
        }

        int[] array = new int[value1];                                       // запросить у пользователя значения элементов массива

        for (int i = 0; i < value1; i++)
        {
            Console.WriteLine("Значение элемента массива");
            string new_item = Console.ReadLine();                 
            if (int.TryParse(new_item, out int int_item))
            {
                array[i] = int_item;
            }
            else
            {
                Console.WriteLine("Вам необходимо ввести число");
                break;                                                       //Можно убрать, и тогда у нас не будет прерыватся программа при ввидении невалидного числа 

            }

        }
        Array.Sort(array);                                                   // Нахождение 2го по величине числа в массиве 

        for (int i = value1 - 1; i > 0; i--)
        {
            if (array[i] == array[i - 1])
            {
                continue;
            }
            else
            {
                Console.Write($"{array[i - 1]} является 2м по величине числом в массиве");

                break;
            }
        }


    }
}

