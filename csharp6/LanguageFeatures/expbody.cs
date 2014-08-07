using System;

public class Program
{
    public static void Main()
    {
    }
}

public class Point(int x, int y) {
    public int X => 2;
    public int Y => 3;
    public double Dist => Math.Sqrt(2);
    public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
}