using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriggerAppearwall : MonoBehaviour
{
    public GameObject target;
    public MeshCollider wall;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target.gameObject.SetActive(true);
            wall.enabled = false;
        }

    }
  
}


