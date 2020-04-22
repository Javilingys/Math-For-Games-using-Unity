using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sphere;
    public GameObject quad;
    //public Transform corner1;
    //public Transform corner2;
    //public Transform corner3;

    Plane mPlane;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        mPlane = new Plane(quad.transform.TransformPoint(vertices[0]),
                            quad.transform.TransformPoint(vertices[1]),
                            quad.transform.TransformPoint(vertices[2]));
        Debug.Log(vertices[0]);
        Debug.Log(vertices[1]);
        Debug.Log(vertices[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float t = 0.0f;

            if(mPlane.Raycast(ray, out t))
            {
                Vector3 hitPoint = ray.GetPoint(t);
                sphere.transform.position = hitPoint;
            }
        }
    }
}
