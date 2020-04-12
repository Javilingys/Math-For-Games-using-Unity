using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    //Coords point = new Coords(10, 20);

    Coords startPointYAxis = new Coords(0, 100);
    Coords endPointYAxis = new Coords(0, -100);

    Coords startPointXAxis = new Coords((float)(100 * 1.6), 0);
    Coords endPointXAxis = new Coords(-(float)(100 * 1.6), 0);

    Coords[] leo = {new Coords(0, 20),
                    new Coords(20, 30),
                    new Coords(80, 30),
                    new Coords(30, 50),
                    new Coords(80, 50),
                    new Coords(70, 60),
                    new Coords(70, 80),
                    new Coords(80, 90),
                    new Coords(95, 80)};

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(point.ToString());
        //Coords.DrawPoint(new Coords(0, 0), 2, Color.magenta);
        //Coords.DrawPoint(point, 2, Color.yellow);

        // y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 0.5f, Color.green);
        // x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.red);

        foreach(Coords c in leo)
        {
            Coords.DrawPoint(c, 2, Color.yellow);
        }

        Coords.DrawLine(leo[0], leo[1], 0.4f, Color.white);
        Coords.DrawLine(leo[1], leo[2], 0.4f, Color.white);
        Coords.DrawLine(leo[0], leo[3], 0.4f, Color.white);
        Coords.DrawLine(leo[3], leo[5], 0.4f, Color.white);
        Coords.DrawLine(leo[2], leo[4], 0.4f, Color.white);
        Coords.DrawLine(leo[4], leo[5], 0.4f, Color.white);
        Coords.DrawLine(leo[5], leo[6], 0.4f, Color.white);
        Coords.DrawLine(leo[6], leo[7], 0.4f, Color.white);
        Coords.DrawLine(leo[7], leo[8], 0.4f, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
