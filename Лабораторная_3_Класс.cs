using System;
using System.Linq;
using System.Reflection;

class Vector
{
    private double[] elements;

    // Конструкторы
    public Vector(int size)
    {
        elements = new double[size];
    }

    public Vector(double[] values)
    {
        this.elements = new double[values.Length];
        elements.CopyTo(this.elements, 0);
    }

    public Vector(Vector vector)
    {
        elements = vector.elements;
    }

    //Свойство для доступа к элементам массива
    public double this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    //Метод ввода с консоли
    public void ReadFromConsole()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            elements[i] = double.Parse(Console.ReadLine());
        }
    }

    //Метод для вывода вектора в виде строки
    public override string ToString()
    {
        return string.Join(", ", elements);
    }

    //Метод для вычисления модуля вектора
    public double GetMagnitude()
    {
        return Math.Sqrt(elements.Select(e => e * e).Sum());
    }

    //Метод для получения наибольшего элемента вектора
    public double GetMaxElement()
    {
        return elements.Max();
    }

    //Метод для получения индекса наименьшего элемента вектора
    public int GetMinElementIndex()
    {
        return Array.IndexOf(elements, elements.Min());
    }

    //Метод для создания нового вектора, состоящего только из положительных элементов
    public Vector GetPositiveElementsVector()
    {
        return new Vector(elements.Where(e => e > 0).ToArray());
    }

    //Метод для сложения двух векторов
    public static Vector Add(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            throw new ArgumentException("Векторы должны быть одинаковой длины");
        }

        double[] result = new double[v1.elements.Length];
        for (int i = 0; i < v1.elements.Length; i++)
        {
            result[i] = v1.elements[i] + v2.elements[i];
        }

        return new Vector(result);
    }

    //Метод для вычисления скалярного произведения двух векторов
    public static double DotProduct(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            throw new ArgumentException("\"Векторы должны быть одинаковой длины");
        }

        double result = 0;
        for (int i = 0; i < v1.elements.Length; i++)
        {
            result += v1.elements[i] * v2.elements[i];
        }

        return result;
    }

    //Метод для проверки двух векторов на равенство
    public static bool AreEqual(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            return false;
        }

        for (int i = 0; i < v1.elements.Length; i++)
        {
            if (v1.elements[i] != v2.elements[i])
            {
                return false;
            }
        }

        return true;
    }
    //Метод для возврата одного элемента по индексу
    public  double ElementByIndex(int newindex)
    {
        return elements[newindex];
    }
    //Метод для изменения одного элемента вектора по индексу и новому значению элемента
    public  double ChangingElement(int newindex, double newvalue)
    {
        return elements[newindex] = newvalue;
    }
    //Метод для линейного поиска элемента в массиве
    public int LinearSearch(double value)
    {
        for (int i = 0; i < v4.elements.Length; i++)
        {
            if (elements[i] == value)
                return i;
        }
        return 1;
    }
    //Метод для проверки того, что массив упорядочен по возрастанию 
    public bool IsSorted()
    {
        for (int i = 1; i < v4.elements.Length; i++)
        {
            if (elements[i] < elements[i - 1])
                return false;
        }
        return true;
    }

    //Вариант 7 
    //Метод для сдвига элементов вектора на заданное число позиций вправо, освободившиеся элементы заполняются нулями
    public void Right(int n)
    {
        for (int i = 0; i < v4.elements.Length - n; i++)
        {
            this.elements[v4.elements.Length - 1 - i] = this.elements[v4.elements.Length - 1 - i - n];
        }
        for (int i = 0; i < n; i++)
        {
            this.elements[i] = 0;
        }
    }
}
