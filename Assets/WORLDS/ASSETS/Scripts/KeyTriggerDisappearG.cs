using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggerDisappearG : MonoBehaviour
{
    public GameObject target;


void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            target.gameObject.SetActive(false);
        }

    }
  
}


