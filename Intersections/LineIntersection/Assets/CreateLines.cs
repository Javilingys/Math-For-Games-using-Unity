using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    Line L1;
    Line L2;

    // Start is called before the first frame update
    void Start()
    {
        L1 = new Line(new Coords(-100, 0, 0), new Coords(200, 150, 0));
        L1.Draw(1, Color.green);
        L2 = new Line(new Coords(0, -100, 0), new Coords(0, 200, 0));
        L2.Draw(1, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
