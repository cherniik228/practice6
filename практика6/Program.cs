
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

struct practice_6
{
   private int[] mas;
   
    public practice_6(int water)
    {
        mas = new int[water];
        Random rnd = new Random();

        for (int i = 0; i < water; i++)
        {
            mas[i] = rnd.Next(100);
        }
    }
    public int max()
    {
     int max = mas [0];

        for (int i = 1; i < mas.Length; i++)
        {
            if (mas[i] > max)
                max = mas [i];
        }
        return max;
    }
    public int min()
    {
        int min = mas[0];

        for (int i = 1; i < mas.Length; i++)
        {
            if (mas[i] < min)
                min = mas[i];
        }
        return min;
    }
    public double sum()
    {
        long sum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            sum += mas[i];
        }
        return (double)sum / mas.Length;
    }
    public void print()
    {
        Console.WriteLine(string.Join(", ",mas));
    }
}

class Print
{
    static void Main()
    {
        Console.Write("ведите размер масива :");
      int water = Convert.ToInt32(Console.ReadLine());

        practice_6 masiv = new practice_6(water);

        Console.WriteLine("Содержимое массива:");
        masiv.print();

        Console.WriteLine($"Наибольший элемент: {masiv.max()}");
        Console.WriteLine($"Наименьший элемент: {masiv.min()}");
        Console.WriteLine($"Среднее значение:   {masiv.sum():F2}");
    }
}
