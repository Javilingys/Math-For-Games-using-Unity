using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CreateBoard : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject housePrefab;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        for(int r = 0; r < 8; r++)
            for (int c = 0; c < 8; c++)
            {
                int randomTile = UnityEngine.Random.Range(0, tilePrefabs.Length);
                Vector3 pos = new Vector3(c, 0, r);
                GameObject tile = Instantiate(tilePrefabs[randomTile],
                    pos,
                    Quaternion.identity);
                tile.name = tile.tag + "_" + r + "_" + c;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
