﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    public Transform camPivot;
    float heading = 0;
    public Transform cam;
    public float sensitivty;

    Vector2 input;


    // Update is called once per frame  
    void Update()
    {
        heading += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivty;
        camPivot.rotation = Quaternion.Euler(0, heading, 0);

        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        transform.position += (camF * input.y + camR * input.x) * Time.deltaTime * 5;
    }
}