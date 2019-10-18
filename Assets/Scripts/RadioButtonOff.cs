using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButtonOff : MonoBehaviour
{
    [SerializeField]
    RadioButtons radioOnScript; 


    private void OnTriggerEnter(Collider col)
    {
        radioOnScript.turnOff();
    }
}
