using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{

    Vector2 Up = new Vector2(0f, 1f);
    Vector2 Right = new Vector2(1f, 0f);
    float speed = 0.8f;

    void Update()
    {
        // Record of position a tank
        Vector3 position = this.transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.x += Up.x * speed;
            position.y += Up.y * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.x += -Up.x * speed;
            position.y += -Up.y * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x += -Right.x * speed;
            position.y += -Right.y * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += Right.x * speed;
            position.y += Right.y * speed;
        }

        this.transform.position = position;
    }
}