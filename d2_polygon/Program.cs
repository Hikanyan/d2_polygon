//https://paiza.jp/works/mondai/drankfast/d2_polygon

using System;

class Program
{
    static void Main()
    {
        var polygon = 0;
        var n = int.Parse(Console.ReadLine());
        polygon = (180 * (n - 2))/n;
        Console.WriteLine(polygon);
    }
}