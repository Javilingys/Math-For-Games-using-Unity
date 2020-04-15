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

    static public float Dot(Coords vector1, Coords vector2)
    {
        return (vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z);
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        float dotDivide = Dot(vector1, vector2) /
            (Distance(new Coords(0,0,0), vector1) * Distance(new Coords(0, 0, 0), vector2));
        return Mathf.Acos(dotDivide); // radians. For degrees * 180/Mathf.PI;
    }

    static public Coords Rotate(Coords vector, float angle, bool clockwise) // in radians
    {
        if (clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }

        float xVal = vector.X * Mathf.Cos(angle) - vector.Y * Mathf.Sin(angle);
        float yVal = vector.X * Mathf.Sin(angle) + vector.Y * Mathf.Cos(angle);

        return new Coords(xVal, yVal, 0);
    }

    static public Coords Cross(Coords vector1, Coords vector2)
    {
        float xVal = vector1.Y * vector2.Z - vector1.Z * vector2.Y;
        float yVal = vector1.Z * vector2.X - vector1.X * vector2.Z;
        float zVal = vector1.X * vector2.Y - vector1.Y * vector2.X;

        return new Coords(xVal, yVal, zVal);
    }
}
