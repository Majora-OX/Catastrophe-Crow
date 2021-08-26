using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportbox : MonoBehaviour
{
    public GameObject Player;
    public GameObject canvas;
    public AudioSource ATMOS;
    public GameObject teleportTOcube;
    public bool triggered;
    public float timer = 0f;
    public GameObject hallwayCamera;
    public AudioSource phone;
    public GameObject roomcamera;
    public bool triggered2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            timer += Time.deltaTime;
            if(timer >= 1.5 && !triggered2)
            {
                Player.GetComponent<PlayerController>().enabled = true;
                Player.GetComponent<AudioSource>().mute = false;
                ATMOS.mute = false;
                phone.mute = false;
                canvas.SetActive(false);
                triggered2 = true;

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Player.GetComponent<PlayerController>().enabled = false; 
            Player.GetComponent<AudioSource>().mute = true;
            canvas.SetActive(true);
            ATMOS.mute = true;
            Player.transform.position = teleportTOcube.transform.position;
            triggered = true;
            hallwayCamera.SetActive(false);
            roomcamera.SetActive(true);
            Player.GetComponent<PlayerController>().playerCamera = roomcamera.transform;

        }

    }
}
