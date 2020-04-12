using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    Coords point = new Coords(10, 20);

    Coords startPointYAxis = new Coords(0, 100);
    Coords endPointYAxis = new Coords(0, -100);

    Coords startPointXAxis = new Coords((float)(100 * 1.6), 0);
    Coords endPointXAxis = new Coords(-(float)(100 * 1.6), 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        //Coords.DrawPoint(new Coords(0, 0), 2, Color.magenta);
        Coords.DrawPoint(point, 2, Color.yellow);

        // y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 0.5f, Color.green);
        // x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
