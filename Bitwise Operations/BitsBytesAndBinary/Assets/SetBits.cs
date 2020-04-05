using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBits : MonoBehaviour
{
    int bSequence = 9 + 1 + 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Convert.ToString(bSequence, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
