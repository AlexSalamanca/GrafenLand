using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
    public Camera playerCamera;

    void Start()
    {
        playerCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        GetMovement();
        //TODO: Make the offset variables
        playerCamera.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y + 5.0f, transform.position.z - 5.0f);
	}
    //TODO: Improve Movement
    private void GetMovement()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(speed * Time.deltaTime, 0f, 0f);
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(0f, 0f, -speed * Time.deltaTime);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0f, 0f, speed * Time.deltaTime);
        //}

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
