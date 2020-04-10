using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRay : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 10; // 00010000000000
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),
            out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position,
                transform.TransformDirection(Vector3.forward) * hit.distance,
                Color.yellow);
            Debug.Log("Hit");
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
