using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
    public Transform characterPosition;
    public Camera playerCamera;

    void Start()
    {
        playerCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        GetMovement();
        //make the offset variables
        playerCamera.transform.position = new Vector3(characterPosition.position.x + 0.5f, characterPosition.position.y + 5.0f, characterPosition.position.z - 5.0f);
	}

    private void GetMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            characterPosition.position += new Vector3(0, 0, characterPosition.position.z * speed * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
    }
}
