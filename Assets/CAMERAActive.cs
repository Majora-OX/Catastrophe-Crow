using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAActive : MonoBehaviour
{
    public GameObject target;








    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.name == "Crow")
        {
            target.gameObject.GetComponent<CameraController>().enabled = true;


        }

    }

}
