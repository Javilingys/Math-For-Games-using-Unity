using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriipt for Vectors Moving to a Point
public class Drive2 : MonoBehaviour
{
    float speed = 0.01f;
    public GameObject fuel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = fuel.transform.position;   
    }
}
