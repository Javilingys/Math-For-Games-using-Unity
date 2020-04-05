using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;
    public float speed = 10.0F;
    float rotationSpeed = 50.0F;
    Animator animator;

    void Start(){
        rb = this.GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        animator.SetBool("Idling", true);
    }
	
    // Update is called once per frame
	void FixedUpdate () {
	
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        Quaternion turn = Quaternion.Euler(0f,rotation,0f);
        rb.MovePosition(rb.position + this.transform.forward * translation);
        rb.MoveRotation(rb.rotation * turn);

        if(translation != 0) 
        {
            animator.SetBool("Idling", false);
        }
        else
        {
            animator.SetBool("Idling", true);
        }

	}
}
