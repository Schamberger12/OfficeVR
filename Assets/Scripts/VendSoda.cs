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
        place = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject can = Instantiate(soda, place, Quaternion.identity);
        can.AddComponent<Rigidbody>(); 
    }
}
