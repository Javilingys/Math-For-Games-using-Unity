using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords
{
    float x;
    float y;
    float z;

    public Coords(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1;
    }

    public override string ToString()
    {
        return "(" + x + "," + y + "," + z + ")";
    }
}
