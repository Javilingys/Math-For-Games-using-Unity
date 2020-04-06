using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;

    public Text attributeDisplay;
    int attributes = 0;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "MAGIC":
                attributes |= MAGIC;
                break;
            case "INTELLIGENCE":
                attributes |= INTELLIGENCE;
                break;
            case "CHARISMA":
                attributes |= CHARISMA;
                break;
            case "FLY":
                attributes |= FLY;
                break;
            case "INVISIBLE":
                attributes |= INVISIBLE;
                break;
            case "ANTIMAGIC":
                attributes &= ~MAGIC;
                break;
            case "ANTIINTELLIGENCE":
                attributes &= ~INTELLIGENCE;
                break;
            case "ANTICHARISMA":
                attributes &= ~CHARISMA;
                break;
            case "ANTIFLY":
                attributes &= ~FLY;
                break;
            case "ANTIINVISIBLE":
                attributes &= ~INVISIBLE;
                break;
            case "REMOVE":
                attributes &= ~(INTELLIGENCE | MAGIC);
                break;
            case "ADD":
                attributes |= (INTELLIGENCE | MAGIC | CHARISMA);
                break;
            case "RESET":
                attributes = 0;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }
       
}
