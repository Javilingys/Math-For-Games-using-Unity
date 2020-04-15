using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmt;
    

    public void AddEnergy(string amt)
    {
        int n;
        if (int.TryParse(amt, out n))
        {
            energyAmt.text = amt;
        }
    }

    public void SetAngle(string amt)
    {
        float n;
        if (float.TryParse(amt, out n))
        {
            n *= Mathf.PI/180.0f;
            tank.transform.up = HolisticMath.Rotate(new Coords(tank.transform.up), n, false).ToVector();
        }
    }


    // Use this for initialization
    void Start () {
        tankPosition.text = tank.transform.position + "";
        fuelPosition.text = fuel.GetComponent<ObjectManager>().objPosition + "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
