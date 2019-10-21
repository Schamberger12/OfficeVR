﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBodySize : MonoBehaviour
{


    [SerializeField]
    GameObject body_representation; 
    

    float timer = 0f;

    float maxScale = 2.2f;
    float minScale = 0.3f;


    void Update()
    {
        if (Input.GetKey(KeyCode.U) || (Input.GetAxisRaw("VRTK_Axis12_RightGrip") != 0))
        {

            body_representation.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime;

            if (body_representation.transform.localScale.x >= maxScale)
            {
                body_representation.transform.localScale = new Vector3(maxScale, maxScale, maxScale);
            }
        }
        if (Input.GetKey(KeyCode.I) || Input.GetAxisRaw("VRTK_Axis11_LeftGrip") != 0)
        {
            body_representation.transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime;
            if (body_representation.transform.localScale.x <= minScale)
            {
                body_representation.transform.localScale = new Vector3(minScale, minScale, minScale);
            }
        }

        if (Input.GetKeyUp(KeyCode.U) || Input.GetAxisRaw("VRTK_Axis12_RightGrip") == 0)
        {
            timer = 0f;
        }
        if (Input.GetKeyUp(KeyCode.I) || Input.GetAxisRaw("VRTK_Axis11_LeftGrip") == 0)
        {
            timer = 0f;
        }
        if (Input.GetKeyDown(KeyCode.U) || Input.GetAxisRaw("VRTK_Axis12_RightGrip") == 0)
        {
            timer = 0f;
        }
        if (Input.GetKeyDown(KeyCode.I) || Input.GetAxisRaw("VRTK_Axis11_LeftGrip") == 0)
        {
            timer = 0f;
        }
    }
}
