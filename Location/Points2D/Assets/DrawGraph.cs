using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;
    public int xMax = 200;
    public int yMax = 200;

    Coords startPointYAxis;
    Coords endPointYAxis;

    Coords startPointXAxis;
    Coords endPointXAxis;
    // Start is called before the first frame update
    void Start()
    {
        startPointXAxis = new Coords(xMax, 0);
        endPointXAxis = new Coords(-xMax, 0);

        startPointYAxis = new Coords(0, yMax);
        endPointYAxis = new Coords(0, -yMax);

        // y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 1, Color.green);
        // x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.red);

        // How many gaps
        int xOffset = (int)(xMax / (float)size);
        for (int x = -xOffset*size; x <= xOffset * size; x += size)
        {
            Coords.DrawLine(new Coords(x, -yMax), new Coords(x, yMax), 0.5f, Color.white);
        }

        int yOffset = (int)(yMax / (float)size);
        for (int y = -yOffset*size; y <= yOffset*size; y += size)
        {
            Coords.DrawLine(new Coords(-xMax, y), new Coords(xMax, y), 0.5f, Color.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
