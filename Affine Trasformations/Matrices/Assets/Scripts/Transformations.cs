using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public GameObject[] points;
    public float angle;
    public Vector3 translation;
    public Vector3 scaling;
    public GameObject center;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 c = new Vector3(center.gameObject.transform.position.x,
                                center.gameObject.transform.position.y,
                                center.gameObject.transform.position.z);
        foreach(GameObject p in points)
        {
            Coords position = new Coords(p.transform.position, 1);

            //p.transform.position = HolisticMath.Translate(position,
            //        new Coords(new Vector3(translation.x, translation.y, translation.z), 0)).ToVector();

            position = HolisticMath.Translate(position,
                    new Coords(new Vector3(-c.x, -c.y, -c.z), 0));
            position = HolisticMath.Scale(position, scaling.x, scaling.y, scaling.z);
            p.transform.position = HolisticMath.Translate(position,
                    new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
