using System;

public class cercle : point
{
    int r;
    cercle(int X, int Y, int R) : base(X, Y)
    {
        r = R;
    }
    public int getR()
    {
        return r;
    }
}
