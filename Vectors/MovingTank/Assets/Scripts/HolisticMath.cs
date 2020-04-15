using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{
   static public Coords GetNormal(Coords vector)
    {
        float length = Distance(new Coords(0, 0, 0), vector);
        vector.X /= length;
        vector.Y /= length;
        vector.Z /= length;

        return vector;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        float diffSquared = Square(point1.X - point2.X) +
                            Square(point1.Y - point2.Y) +
                            Square(point1.Z - point2.Z);
        float squareRoot = Mathf.Sqrt(diffSquared);
        return squareRoot;
    }

    static public float Square(float value)
    {
        return value * value;
    }
}
