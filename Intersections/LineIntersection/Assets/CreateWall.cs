using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    Line wall;
    Line ballPath;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        wall = new Line(new Coords(5, -2, 0), new Coords(0, 5, 0));
        wall.Draw(1, Color.blue);

        ballPath = new Line(new Coords(-6, 0, 0), new Coords(100, 0, 0));
        ballPath.Draw(0.1f, Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
