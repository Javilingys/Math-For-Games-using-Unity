using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line
{
    Coords A;
    Coords B;
    Coords v;

    public Line(Coords _A, Coords _B)
    {
        A = _A;
        B = _B;
        v = new Coords(B.x - A.x, B.y - A.y, B.z - A.z);
    }

    public Coords GetPointAt(float t)
    {
        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new Coords(xt, yt, zt);
    }
}
