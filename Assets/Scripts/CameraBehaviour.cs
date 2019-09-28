using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

    public GameObject rotator;
    

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float pitch = 0;
    public float yaw = 0;

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButton(1))
        {
            SetRotation();
        }
        
	}

    private void SetRotation()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch += speedV * Input.GetAxis("Mouse Y");

        rotator.transform.eulerAngles = new Vector3(-pitch, yaw, 0.0f);
    }
}
