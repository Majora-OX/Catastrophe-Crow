using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriggerAppear : MonoBehaviour
{
    public GameObject target;
    public GameObject TurnCamera;
    public bool disablelockon;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (disablelockon) { TurnCamera.GetComponent<CameraController>().lockingOn.allowLockingOn = false; }
            target.gameObject.SetActive(true);
        }

    }
  
}


