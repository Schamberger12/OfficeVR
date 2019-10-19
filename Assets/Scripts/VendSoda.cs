using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendSoda : MonoBehaviour
{
    [SerializeField]
    GameObject soda;

    [SerializeField]
    GameObject spawnPoint;

    Vector3 place; 

    private void Start()
    {
        place = new Vector3(spawnPoint.transform.localPosition.x, spawnPoint.transform.localPosition.y, spawnPoint.transform.localPosition.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(soda, place, Quaternion.identity); 
    }
}
