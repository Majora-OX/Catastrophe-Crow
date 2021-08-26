using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FatherTextforest : MonoBehaviour
{
    
    private float Timer = 0;
    private float timePerCharacter = 0.2f;
    private int messageIndex = 0;
    public AudioSource end;
    private bool played = false;
    private float Timer2 = 0;
    public GameObject background;
    public GameObject controlledcamera;
    public GameObject maincamera;
    public GameObject crow;
    
    private bool played2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
        Timer += Time.deltaTime;
        if (Timer >= 3f && !played)
        {
             
            //Timer += timePerCharacter;
            
            background.SetActive(true); played = true;
            maincamera.GetComponent<MoveToTarget2>().enabled = false;
        }
        if (Timer >= 7f && !played2)
        {
         
            end.Play();
            background.SetActive(false);
            //controlledcamera.GetComponent<CameraController>().follow.playerHeight = -50;
            //controlledcamera.GetComponent<CameraController>().follow.cameraHeight =  4.5f;
            //controlledcamera.GetComponent<CameraController>().cameraDistance = 0.35f;
           
            maincamera.GetComponent<MoveToTarget3>().enabled = true;
            maincamera.GetComponent<MoveToTarget3>().switched = true;
            played2 = true;
            
            
           // maincamera.GetComponent<MoveToTarget3>().switched = true;
        }
        if (Timer >= 9)
        {
            // maincamera.GetComponent<Camera>().depth = -1;
            // controlledcamera.GetComponent<Camera>().depth = 1;
            
            crow.GetComponent<PlayerController>().enabled = true;

            crow.GetComponent<AudioSource>().mute = false ;
    }



    }
}
