using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDark : MonoBehaviour
{
    [SerializeField]
    GameObject dart;

    [SerializeField]
    GameObject spawnPoint;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Dart"))
        {
            Instantiate(dart, spawnPoint.transform.localPosition, Quaternion.identity); 
        }
    }
}
