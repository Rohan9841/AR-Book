using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour {

    //variable to store the direction of ship
    public Vector3 planeDirection;

    // Use this for initialization
    void Start () {
		//initializing shipDirection. Here, 0.5 is the ship direction
        planeDirection = new Vector3(0f, 0f, 0.5f);	

	}
	
	// Update is called once per frame
	void Update () {
        //Every frame, the ship is moving in z-direction.
        transform.Translate(planeDirection * Time.deltaTime);
    }
}
