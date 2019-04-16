using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	//Add Variables here



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Add Movement Code Here
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("you pressed the d key");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("you pressed the w key");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("you pressed the a key");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("you pressed the s key");
        }

    }
}
