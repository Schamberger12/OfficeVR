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
        if (Input.GetKey("up"))
        {

            room.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime; 

            if(room.transform.localScale == new Vector3(minScale, minScale, minScale))
            {
                room.transform.localScale = new Vector3(minScale, minScale, minScale); 
            }
        }
        if (Input.GetKey("down"))
        {
            room.transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime;
            if (room.transform.localScale == new Vector3(maxScale, maxScale, maxScale))
            {
                room.transform.localScale = new Vector3(maxScale, maxScale, maxScale);
            }
        }

        if (Input.GetKeyUp("up"))
        {
            timer = 0f; 
        }
        if (Input.GetKeyUp("down"))
        {
            timer = 0f; 
        }
        if (Input.GetKeyDown("up"))
        {
            timer = 0f; 
        }
        if (Input.GetKeyDown("down"))
        {
            timer = 0f; 
        }
    }
}
