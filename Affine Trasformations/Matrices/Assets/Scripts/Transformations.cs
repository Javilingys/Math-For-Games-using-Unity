using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public GameObject[] points;
    public float angle;
    public Vector3 translation;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject p in points)
        {
            Coords position = new Coords(p.transform.position, 1);

            p.transform.position = HolisticMath.Translate(position,
                    new Coords(new Vector3(translation.x, translation.y, translation.z), 0)).ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
