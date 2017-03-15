using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 7;
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        

        Vector3 input = new Vector3(horizontal, 0, vertical);
        input *= speed;

        Rigidbody rbody = GetComponent<Rigidbody>();
        rbody.AddForce(input);
        if(Input.GetKeyDown("space"))
            {
            rbody.AddForce(0, 300, 0);
            }
	}
}
