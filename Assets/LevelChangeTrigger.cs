using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeTrigger : MonoBehaviour
{
   
    public GameObject Canvas;
    public GameObject Player;
    public GameObject TurnCamera;
    public AudioSource atmos;
    public AudioSource outrosound;
    public int desiredlevel;
    public bool nostop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            TurnCamera.GetComponent<CameraController>().lockingOn.allowLockingOn = false;
            Canvas.GetComponent<Animator>().SetBool("Triggered", true);
            outrosound.Play();
            if (!nostop) { Player.GetComponent<PlayerController>().enabled = false; } 
            Player.GetComponent<AudioSource>().enabled = false;


        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
        }

    }
    void Update()
    {
        
        if (Canvas.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Done"))
        {
            atmos.mute = true;
            SceneManager.LoadScene(desiredlevel, LoadSceneMode.Single);
        }
    }
}
