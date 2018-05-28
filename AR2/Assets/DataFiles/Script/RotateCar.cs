using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour {

    //Variable to store rotating direction.
    public Vector3 RotateDirection;

	// Use this for initialization
	void Start () {
        //Initializing RotateDirection
        RotateDirection = new Vector3(0f, 45f, 0f);	
	}
	
	// Update is called once per frame
	void Update () {
        //In each frame, the car rotates
        transform.Rotate(RotateDirection * Time.deltaTime);
	}
}
