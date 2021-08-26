using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSoundTrigger : MonoBehaviour
{
    
    public AudioSource water;
    public GameObject Camera;





   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.name == "Crow")
        {
            Camera.GetComponent<CameraController>().cameraDistance = 0.50f;
            Camera.GetComponent<CameraController>().follow.movementDampening = 0.1f;
            water.Play();

        }

    }
  
}


