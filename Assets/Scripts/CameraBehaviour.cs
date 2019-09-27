using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float pitch = 0;
    public float yaw = 0;

    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 5.0f, player.transform.position.z - 5.0f);

        if (Input.GetMouseButton(1))
        {
            SetRotation();
        }
        
	}

    private void SetRotation()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
