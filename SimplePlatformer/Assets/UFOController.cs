using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

    //Add Variables here
    public Rigidbody2D theRB2d;
    public float movementSpeed;


	// Use this for initialization
	void Start () 
    {
        theRB2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		//Add Movement Code Here
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("you pressed the d key");
            theRB2d.velocity += new Vector2(1.0f,0.0f)*movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("you pressed the w key");
            theRB2d.velocity += new Vector2(0f, 1.0f)*movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("you pressed the a key");
            theRB2d.velocity += new Vector2(-1.0f,0.0f)*movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("you pressed the s key");
            theRB2d.velocity += new Vector2(0.0f,-1.0f)*movementSpeed;
        }

    }
}
