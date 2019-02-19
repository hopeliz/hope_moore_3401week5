using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.z < 21.1)
        {
            transform.position += Vector3.forward / 10;
        }

        //Ray playerRay = new Ray(transform.position, Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 5.0F))
        {
            print(hit.collider.name);
        }
        else
        {
            print("NOTHING AHEAD");
        }
	}
}
