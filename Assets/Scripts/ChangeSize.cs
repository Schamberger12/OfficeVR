using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    [SerializeField]
    GameObject room;

    //[SerializeField]
    //GameObject charPoint;

    //[SerializeField]
    //GameObject simulatedCamera;

    //[SerializeField]
    //GameObject VRCamera;

    //[SerializeField]
    //GameObject bodyRepresentation; 

    float timer = 0f;

    float maxScale = 5f;
    float minScale = 0.3f;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {

            room.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime; 

            if(room.transform.localScale == new Vector3(minScale, minScale, minScale))
            {
                room.transform.localScale = new Vector3(minScale, minScale, minScale); 
            }
        }
        if (Input.GetKey(KeyCode.I))
        {
            room.transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime;
            if (room.transform.localScale == new Vector3(maxScale, maxScale, maxScale))
            {
                room.transform.localScale = new Vector3(maxScale, maxScale, maxScale);
            }
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            timer = 0f; 
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            timer = 0f; 
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            timer = 0f; 
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            timer = 0f; 
        }
    }
}
