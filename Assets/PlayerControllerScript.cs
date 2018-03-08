using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

    // Public variables
    public float walkspeed;

    // Private variables 
    private Rigidbody rb;
   private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
	}

     void FixedUpdate()
    {
        Move();  
    }

    private void Move()
    {
        rb.velocity = moveDirection * walkspeed * Time.deltaTime;
    }

}
