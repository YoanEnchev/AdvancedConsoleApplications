using System;
using System.Numerics;

class Line
{
    public long x1 { get; set; }

    public long y1 { get; set; }

    public long x2 { get; set; }

    public long y2 { get; set; }

    public BigInteger criticalRatio
    {
        get
        {
            BigInteger criticalRatio = BigInteger.Abs((x2 + y2) - (x1 + y1));
            return criticalRatio;
        }
    }
}

