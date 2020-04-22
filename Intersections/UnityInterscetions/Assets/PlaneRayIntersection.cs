using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sphere;
    public GameObject quad;
    public GameObject[] fences;
    Vector3[] fenceNormals;

    Plane mPlane;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        mPlane = new Plane(quad.transform.TransformPoint(vertices[0]) + new Vector3(0, 0.3f, 0),
                            quad.transform.TransformPoint(vertices[1]) + new Vector3(0, 0.3f, 0),
                            quad.transform.TransformPoint(vertices[2]) + new Vector3(0, 0.3f, 0));
        fenceNormals = new Vector3[fences.Length];
        for(int i = 0; i < fences.Length; i++)
        {
            Vector3 normal = fences[i].GetComponent<MeshFilter>().mesh.normals[0];
            fenceNormals[i] = fences[i].transform.TransformVector(normal);
        }
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

                bool inside = true;
                for (int i = 0; i < fences.Length; i++)
                {
                    Vector3 hitPointToFence = fences[i].transform.position - hitPoint;
                    inside = inside && Vector3.Dot(hitPointToFence, fenceNormals[i]) <= 0;
                }
                  
                if(inside)
                    sphere.transform.position = hitPoint;
            }
        }
    }
}
