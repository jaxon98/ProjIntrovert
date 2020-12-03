using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{

    // Use this for initialization  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.0f, 0f, -0.01f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.0f, 0f, 0.01f);
        }


        bool isLeftButtonDown = Input.GetMouseButtonDown(0);
        bool isRightButtonDown = Input.GetMouseButtonDown(1);
        bool isMiddleButtonDown = Input.GetMouseButtonDown(2);

        print(isLeftButtonDown);

    }

}