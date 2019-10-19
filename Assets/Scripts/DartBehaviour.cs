using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject dartBoard;

    Collider boardCollider;
    Collider dartCollider; 

    private void Start()
    {
        boardCollider = dartBoard.GetComponent<Collider>();
        dartCollider = gameObject.GetComponent<Collider>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DartBoard"))
        {

            Debug.Log("In Board!"); 
            gameObject.GetComponent<Rigidbody>().isKinematic = true; 
            gameObject.transform.SetParent(dartBoard.transform);
            gameObject.transform.localPosition = new Vector3(transform.localPosition.x - 0.5f, 0.9f, transform.localPosition.y + 4.65f); 
        }
    }


}
