using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour {
    Vector3 direction;
	// Use this for initialization
	void Start () {
        direction = new Vector3(2f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * Time.deltaTime);
	}
}
