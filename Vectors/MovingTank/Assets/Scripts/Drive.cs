using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{


    void Update()
    {
        // Record of position a tank
        Vector3 position = this.transform.position;

        position.x += 0.1f;
        position.y += 0.1f;
        this.transform.position = position;
    }
}