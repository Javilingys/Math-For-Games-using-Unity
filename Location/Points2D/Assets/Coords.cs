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

    static public void DrawPoint(Coords position, float width, Color colour)
    {
        // Create a new GameObject add to him LineRendere
        GameObject line = new GameObject("Point_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        // Add a material to lineRenderer
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.x - width / 3.0f, position.y - width / 3.0f, position.z));
        lineRenderer.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

    static public void DrawLine(Coords startPoint, Coords endPoint, float width, Color colour)
    {
        GameObject line = new GameObject("Line_" + startPoint.ToString() + "_" + endPoint.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.SetPosition(0, new Vector3(startPoint.x, startPoint.y, startPoint.z));
        lineRenderer.SetPosition(1, new Vector3(endPoint.x, endPoint.y, endPoint.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
