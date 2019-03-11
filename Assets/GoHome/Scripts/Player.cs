using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//making sure this gameObject has the rigid body component
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    public float movementSpeed = 20f;
    private Rigidbody rigid;

    
    // Use this for initialization
	void Start ()
    {
        // get reference to rigidbody
        rigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // get input axis as float for x and y
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        //create Input Vector
        Vector3 input = new Vector3(inputX, 0, inputZ);

        //Apply velocity
        rigid.velocity = input * movementSpeed;
    }
}
