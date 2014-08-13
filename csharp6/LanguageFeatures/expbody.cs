using System;

public class Program
{
    public static void Main()
    {
    }


    public void DoWork(string name)
    {
    }

}

public class Point(int x, int y) 
{
    public int X => x;
    public int Y => y;
    public double Distance => Math.Sqrt(x*x + y*y);
    public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
}

 