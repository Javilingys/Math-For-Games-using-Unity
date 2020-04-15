using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw2DAxis : MonoBehaviour {

    Coords startPointXAxis = new Coords(0, 0);
    Coords endPointXAxis = new Coords(10, 0);
    Coords startPointYAxis = new Coords(0, 0);
    Coords endPointYAxis = new Coords(0, 10);

	void Start () {
        //x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 0.5f, Color.red);
        //y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 0.5f, Color.green);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
