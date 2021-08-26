using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manfredtalktrigger : MonoBehaviour
{
   
    //public GameObject Canvas;
    public GameObject Player;
  
    public AudioSource outrosound;
   
    public bool nostop;
    public GameObject Camera;
    public bool can;
    public GameObject Manfred;
    public GameObject TextCanvas;
    public GameObject ControlledCamera;
    


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("B/Talk&Interact") && ControlledCamera.GetComponent<CameraController>().lockingOn.allowLockingOn)
            {
                ControlledCamera.GetComponent<CameraController>().lockingOn.allowLockingOn = false;
                //Canvas.GetComponent<Animator>().SetBool("Triggered", true);
                outrosound.Play();
                if (!nostop) { Player.GetComponent<PlayerController>().enabled = false; Player.GetComponent<Animator>().enabled = false; }
                Player.GetComponent<AudioSource>().enabled = false;
                Camera.GetComponent<Camera>().depth = 1;
                if (can) { Camera.GetComponent<MOVETOTARGETCAMERA>().can = true; Manfred.GetComponent<LookAtToggleEdited>().direction = true; }
                Manfred.GetComponent<LookAtToggleEdited>().looking = true;
                Camera.GetComponent<MOVETOTARGETCAMERA>().switched = true;
                TextCanvas.SetActive(true);
                
            }

        }

    }
   
 
}
