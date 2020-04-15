using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Coords(float _x, float _y)
    {
        X = _x;
        Y = _y;
        Z = -1;
    }

    public Coords(float _x, float _y, float _z)
    {
        X = _x;
        Y = _y;
        Z = _z;
    }

    public override string ToString()
    {
        return "(" + X + "," + Y + "," + Z + ")";
    }

    public Vector3 ToVector()
    {
        return new Vector3(X, Y, Z);
    }

    static public void DrawLine(Coords startPoint, Coords endPoint, float width, Color colour)
    {
        GameObject line = new GameObject("Line_" + startPoint.ToString() + "_" + endPoint.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.X, startPoint.Y, startPoint.Z));
        lineRenderer.SetPosition(1, new Vector3(endPoint.X, endPoint.Y, endPoint.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

    static public void DrawLine(Coords position, float width, Color colour)
    {
        GameObject line = new GameObject("Line_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.X - width / 3.0f, position.Y - width / 3.0f, position.Z));
        lineRenderer.SetPosition(1, new Vector3(position.X + width / 3.0f, position.Y + width / 3.0f, position.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
