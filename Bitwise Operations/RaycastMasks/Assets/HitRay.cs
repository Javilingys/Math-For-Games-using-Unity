using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRay : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        /* int cubeLayerMask = 1 << 10; // 00010000000000
        int sphereLayerMask = 1 << 9;

        int layerMask = cubeLayerMask | sphereLayerMask;

        //layerMask = ~layerMask; */

        int layerMask = ((1 << 10) | (1 << 9)); 

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),
            out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position,
                transform.TransformDirection(Vector3.forward) * hit.distance,
                Color.yellow);
            Debug.Log("Hit");
            Debug.Log(hit.collider);
        }
        else
        {
            Debug.DrawRay(transform.position,
                transform.TransformDirection(Vector3.forward) * 1000,
                Color.red);
            Debug.Log("Missed");
        }
    }
}
