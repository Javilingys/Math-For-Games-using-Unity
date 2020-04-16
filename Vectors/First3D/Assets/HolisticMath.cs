using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{
    static public float Square(float value)
    {
        return value * value;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        float diffSquared = Square(point1.x - point2.x) + 
                            Square(point1.y - point2.y) + 
                            Square(point1.z - point2.z);
        float squareRoot = Mathf.Sqrt(diffSquared);
        //if you are interested in how the Sqrt is calculated see
        //https://www.codeproject.com/Articles/570700/SquareplusRootplusalgorithmplusforplusC
        return squareRoot;

    }

    static public Coords GetNormal(Coords vector)
    {
        float length = Distance(new Coords(0, 0, 0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }

    static public float Dot(Coords vector1, Coords vector2)
    {
        return (vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z);
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        float dotDivide = Dot(vector1, vector2) / (Distance(new Coords(0, 0, 0), vector1) * Distance(new Coords(0, 0, 0), vector2));
        return Mathf.Acos(dotDivide);  //radians.  For degrees * 180/Mathf.PI;
    }

    static public Coords Cross(Coords vector1, Coords vector2)
    {
        float iMult = vector1.y * vector2.z - vector1.z * vector2.y;
        float jMult = vector1.z * vector2.x - vector1.x * vector2.z;
        float kMult = vector1.x * vector2.y - vector1.y * vector2.x;
        Coords crossProd = new Coords(iMult, jMult, kMult);
        return crossProd;
    }

    static public Coords Rotate(Coords vector, float angle, bool clockwise)
    //angle in radians please
    {
        if (clockwise)
            angle = 2*Mathf.PI - angle;

        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);
        return new Coords(xVal, yVal, 0); 
    }
}
