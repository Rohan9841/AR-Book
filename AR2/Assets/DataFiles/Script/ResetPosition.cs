using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 orgPos;

    // Use this for initialization
    void Start()
    {
        orgPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "PlaneWall")
        {
            transform.localPosition = orgPos;
        }
        else if (collision.transform.tag == "ShipWall")
        {
            transform.localPosition = orgPos;
        }
        else if(collision.transform.tag == "PlaneWall(1)")
        {
            transform.localPosition = orgPos;
        }
    }
}
