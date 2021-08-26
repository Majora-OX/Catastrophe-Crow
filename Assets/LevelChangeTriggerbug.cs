using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeTriggerbug : MonoBehaviour
{
   
   
    public GameObject Player;
  
  
    public int desiredlevel;
    public bool nostop;
    public GameObject TurnCamera;
    public GameObject canvas;
    public AudioSource ATMOS;
    public AudioSource ATMOS2;
    public bool twoatmos = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.name == "Crow")
        {
            TurnCamera.GetComponent<CameraController>().lockingOn.allowLockingOn = false;
            if (!nostop) { Player.GetComponent<PlayerController>().enabled = false; } 
            Player.GetComponent<AudioSource>().mute = true;
            canvas.SetActive(true);
            ATMOS.mute = true;
            if (twoatmos) { ATMOS2.mute = true; }
          SceneManager.LoadScene(desiredlevel, LoadSceneMode.Single);

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
        }

    }
   
}
