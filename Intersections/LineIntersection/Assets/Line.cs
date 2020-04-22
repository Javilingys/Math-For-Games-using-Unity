using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line
{
    public Coords A;
    Coords B;
    public Coords v;

    public enum LINETYPE { LINE, SEGMENT, RAY};
    LINETYPE type;

    public Line(Coords _A, Coords _B, LINETYPE _type)
    {
        A = _A;
        B = _B;
        type = _type;
        v = new Coords(B.x - A.x, B.y - A.y, B.z - A.z);
    }

    public Line(Coords _A, Coords _V)
    {
        A = _A;
        v = _V;
        B = _A + v;
        type = LINETYPE.SEGMENT;
    }


    public float IntersectsAt(Line l)
    {
        if(HolisticMath.Dot(Coords.Perp(l.v),v) == 0)
        {
            return float.NaN;
        }
        Coords c = l.A - this.A;
        float t = HolisticMath.Dot(Coords.Perp(l.v), c) / HolisticMath.Dot(Coords.Perp(l.v), v);
        if((t < 0 || t > 1) && type == LINETYPE.SEGMENT)
        {
            return float.NaN;
        }
        return t;
    }

    public void Draw(float width, Color col)
    {
        Coords.DrawLine(A, B, width, col);
    }

    public Coords Lerp(float t)
    {
        if (type == LINETYPE.SEGMENT)
            t = Mathf.Clamp(t, 0, 1);
        else if (type == LINETYPE.RAY && t < 0)
            t = 0;

        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new Coords(xt, yt, zt);
    }

    //3D Line Intersection Algorithm
    //http://inis.jinr.ru/sl/vol1/CMC/Graphics_Gems_1,ed_A.Glassner.pdf


}
