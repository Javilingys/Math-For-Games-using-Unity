using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;


    Coords startPointYAxis = new Coords(0, 100);
    Coords endPointYAxis = new Coords(0, -100);

    Coords startPointXAxis = new Coords(160, 0);
    Coords endPointXAxis = new Coords(-160, 0);
    // Start is called before the first frame update
    void Start()
    {
        // y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 1, Color.green);
        // x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.red);

        for (int x = -160; x <= 160; x += size)
        {
            Coords.DrawLine(new Coords(x, -100), new Coords(x, 100), 0.5f, Color.white);
        }

        for (int y = -100; y <= 100; y += size)
        {
            Coords.DrawLine(new Coords(-160, y), new Coords(160, y), 0.5f, Color.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
