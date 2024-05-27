using System;
using System.Drawing;

class Program
{
    static void Main()
    {

        int size = 100;
        int[] array1 = new int[size];
        int[] array2 = new int[size];
        Random randNum = new Random();
        WypelnijTablice(array1);
        WypelnijTablice(array2);
        Console.WriteLine("Tablica 1:");
        PrintArray(array1);
        Console.WriteLine("Tablica 2:");
        PrintArray(array2);
        Console.Write("Jakiej liczby szukasz? ");
        string input = Console.ReadLine();
        int wybor = 1;
        try
        {
            wybor = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Zły wybór.");
        }
        Console.WriteLine("Znaleziono liczbę na pozycji " + SzukajLiniowy(array1, wybor));
        Console.WriteLine("Znaleziono liczbę na pozycji " + SzukajWartownik(array1, wybor));
    }

    static void WypelnijTablice(int[] array)
    {
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(1, 100);
        }
    }

    public static int SzukajLiniowy(int[] array, int liczba)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == liczba)
                return i;
        }
        return -1;
    }

    public static int SzukajWartownik(int[] array, int liczba)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == liczba)
                return i;
            else if (array[i] > liczba)
                return -1;
        }
        return -1;
    }

    static void PrintArray(int[] array)
    {
        foreach (var zmienna in array)
        {
            Console.Write(zmienna + " ");
        }
        Console.WriteLine();
    }
}
