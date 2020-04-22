using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlane : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    Plane plane;

    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(new Coords(A.position), 
                          new Coords(B.position), 
                          new Coords(C.position));

        for(float s = -5; s < 5; s += 0.1f)
        {
            for(float t = -5; t < 5; t += 0.1f)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = plane.Lerp(s, t).ToVector();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
