using System;
public class Point 
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }


    public double Distance
    {
        get
        {
            return Math.Sqrt((double)(this.X * this.X + this.Y * this.Y));
        }
    }

    public Point Move(int dx, int dy) => new Point(X + dx, Y + dy);
}

