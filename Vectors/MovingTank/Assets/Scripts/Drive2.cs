using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriipt for Vectors Moving to a Point
public class Drive2 : MonoBehaviour
{
    float speed = 5f;
    public GameObject fuel;
    Vector3 direction;
    float stoppingDistance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();

        this.transform.up = HolisticMath.LookAt2D(new Coords(this.transform.up),
                                                new Coords(this.transform.position),
                                                new Coords(fuel.transform.position)).ToVector();
        /*direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();
        // Coords(0,1,0) - facing of the tank
        float angle = HolisticMath.Angle(new Coords(this.transform.up), new Coords(direction)); //* 180.0f/Mathf.PI;

        bool clockwise = false;
        if(HolisticMath.Cross(new Coords(this.transform.up), dirNormal).Z < 0)
        {
            clockwise = true;
        }

        Coords newDir = HolisticMath.Rotate(new Coords(0, 1, 0), angle, clockwise);
        this.transform.up = new Vector3(newDir.X, newDir.Y, newDir.Z); */
    }

    // Update is called once per frame
    void Update()
    {
        if(HolisticMath.Distance(new Coords(this.transform.position),
                                new Coords(fuel.transform.position)) > stoppingDistance)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }
}
