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
    }

    // Update is called once per frame
    void Update()
    {
        if(HolisticMath.Distance(new Coords(this.transform.position),
                                new Coords(fuel.transform.position)) > stoppingDistance)
        {
            this.transform.position += direction * speed;
        }
    }
}
