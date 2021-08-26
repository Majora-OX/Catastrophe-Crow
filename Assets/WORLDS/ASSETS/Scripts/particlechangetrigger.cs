using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlechangetrigger : MonoBehaviour
{
    public GameObject target;
    
    





   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.name == "Crow")
        {
            target.gameObject.GetComponent<ParticleMaterialChangeWithKeyPress>().triggered = true;
     

        }

    }
  
}


