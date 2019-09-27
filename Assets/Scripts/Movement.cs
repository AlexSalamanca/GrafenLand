using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
    

	// Update is called once per frame
	void Update () {
        GetMovement();
        //TODO: Make the offset variables
        
	}
    //TODO: Improve Movement
    private void GetMovement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
