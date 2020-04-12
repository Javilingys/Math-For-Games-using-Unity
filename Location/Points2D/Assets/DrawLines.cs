using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    Coords point = new Coords(10, 20);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        Coords.DrawPoint(point, 2, Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
