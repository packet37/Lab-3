using System.Numerics;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(new double[] { 1, 2, 3 });
        Vector v2 = new Vector(new double[] { 4, 5, 6 });

        Console.WriteLine("v1: " + v1.ToString());
        Console.WriteLine("v2: " + v2.ToString());

        Vector v3 = Vector.Add(v1, v2);
        Console.WriteLine("v1 + v2 = " + v3.ToString());

        double dotProduct = Vector.DotProduct(v1, v2);
        Console.WriteLine("v1 * v2 = " + dotProduct);

        bool equal = Vector.AreEqual(v1, v2);
        Console.WriteLine("v1 == v2: " + equal);

        Vector v4 = new Vector(3);
        v4.ReadFromConsole();
        Console.WriteLine("v4: " + v4.ToString());
        Console.WriteLine("Модуль v4: " + v4.GetMagnitude());
        Console.WriteLine("Максимальный элемент v4: " + v4.GetMaxElement());
        Console.WriteLine("Индекс минимального элемента v4: " + v4.GetMinElementIndex());
        //Методы из индвидуального задания
        Console.WriteLine("Введите индекс элемента, который хотите увидеть");
        int newindex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение элемента, который хотите увидеть");
        int newvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Элемент с введенным индексом: " +v4.ElementByIndex(newindex));
        Console.WriteLine("Измененный вектор" + v4.ChangingElement(newindex,newvalue));
        Console.WriteLine("Найденный элемент" + v4.LinearSearch());
        Console.WriteLine("Упорядочен ли массив по возрастанию: " + v4.IsSorted());
        Console.WriteLine("Введите, на сколько позиций вы хотите сдвинуть вектор: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вектор, сдвинутый на n позиций вправо" + v4.Right(n));
        Vector v5 = v4.GetPositiveElementsVector();
        Console.WriteLine("v4: " + v5.ToString());

        Console.ReadKey();
    }
}
