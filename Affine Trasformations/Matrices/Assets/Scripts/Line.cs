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

    public Coords Reflect(Coords normal)
    {

        Coords norm = normal.GetNormal();
        Coords vnorm = v.GetNormal();

        float d = HolisticMath.Dot(norm, vnorm);

        if (d == 0) return v;

        float vn2 = d * 2;
        Coords r = vnorm - norm * vn2;
        return r;
    }

    public float IntersectsAt(Plane p)
    {
        Coords normal = HolisticMath.Cross(p.u, p.v);
        if (HolisticMath.Dot(normal, v) == 0)
            return float.NaN;
        float t = HolisticMath.Dot(normal, p.A - A) / HolisticMath.Dot(normal, v);
        return t;
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
