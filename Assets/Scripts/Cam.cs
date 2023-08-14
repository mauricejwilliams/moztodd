using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float Sensitivity = 130;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

            float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        
    }
}

