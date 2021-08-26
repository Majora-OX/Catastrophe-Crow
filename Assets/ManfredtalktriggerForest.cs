using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManfredtalktriggerForest : MonoBehaviour
{
   
    //public GameObject Canvas;
    public GameObject Player;
    private float Timer = 0;
    public AudioSource start;
    public AudioSource end;
    public bool nostop;
    public GameObject Camera;
    public GameObject background;
    public GameObject maincamera;
    public GameObject phonetrig;
    public GameObject invwalls;
    public GameObject glitchcube;
    
   // public GameObject TextCanvas;
    private bool played;
    private bool played2;
    private bool played3;


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !played)
        {
            if (Input.GetButtonDown("B/Talk&Interact"))
            {
                RenderSettings.fogEndDistance = 11.5f;
                Camera.GetComponent<CameraController>().lockingOn.allowLockingOn = false;
                start.Play();
                if (!nostop) { Player.GetComponent<PlayerController>().enabled = false; Player.GetComponent<Animator>().enabled = false; }
                Player.GetComponent<AudioSource>().mute = true;
                maincamera.GetComponent<Camera>().depth = 1;
                maincamera.GetComponent<MoveToTarget2>().switched = true;
                invwalls.SetActive(true);
                played = true;
                
            }

        }

    }
    public void Update()
    {
        if(played)
        {
            Timer += Time.deltaTime;
            if (Timer >= 3f && !played2)
            {

                //Timer += timePerCharacter;

                background.SetActive(true); played2 = true;
                Destroy(maincamera.GetComponent<MoveToTarget2>());
            }
            if (Timer >= 7f && !played3)
            {

                end.Play();
                background.SetActive(false);
                

                maincamera.GetComponent<MoveToTarget3>().enabled = true;
                maincamera.GetComponent<MoveToTarget3>().switched = true;
                played3 = true;


                // maincamera.GetComponent<MoveToTarget3>().switched = true;
            }
            if (Timer >= 8)
            {
                // maincamera.GetComponent<Camera>().depth = -1;
                // controlledcamera.GetComponent<Camera>().depth = 1;

                Player.GetComponent<PlayerController>().enabled = true;
                Player.GetComponent<Animator>().enabled = true;

                Player.GetComponent<AudioSource>().mute = false;
                phonetrig.SetActive(true);
                glitchcube.SetActive(true);
            }
        }
    }


}
