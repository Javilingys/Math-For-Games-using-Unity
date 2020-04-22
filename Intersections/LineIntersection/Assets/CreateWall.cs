using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    Line wall;
    Line ballPath;
    public GameObject ball;
    Line trajectory;

    // Start is called before the first frame update
    void Start()
    {
        wall = new Line(new Coords(5, -2, 0), new Coords(0, 5, 0));
        wall.Draw(1, Color.blue);

        ballPath = new Line(new Coords(-6, 0, 0), new Coords(100, 0, 0));
        ballPath.Draw(0.1f, Color.yellow);

        ball.transform.position = ballPath.A.ToVector();

        float t = ballPath.IntersectsAt(wall);
        float s = wall.IntersectsAt(ballPath);
        if(t == t && s == s)
        {
            trajectory = new Line(ballPath.A, ballPath.Lerp(t), Line.LINETYPE.SEGMENT);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.position = trajectory.Lerp(Time.time).ToVector();
    }
}
