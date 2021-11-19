using System;

public class ellipse : point
{
    //r_1:grand rayan , r_2 petit rayan .
    int r_1 , r_2;
    ellipse(int X, int Y, int R_1 , int R_2) : base(X, Y)
    {
        r_1= R_1;
        r_2 = R_2;
    }
    public int getR_1()
    {
        return r_1;
    }
    public int getR_2()
    {
        return r_2;
    }
}

