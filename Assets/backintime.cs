using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backintime : MonoBehaviour
{
    public bool trigger;
    public GameObject maincamera;
    public GameObject lolstairs;
    public GameObject player;
    public AudioSource phone;
    public AudioSource father;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            phone.mute = true;
            father.mute = true;
            lolstairs.SetActive(true);
            // GetComponent<ColliderTriggerCameraMoveChanger>().enabled = true;
            maincamera.GetComponent<MoveToTarget3>().enabled = false;
            maincamera.GetComponent<Animator>().enabled = true;
            trigger = true;
        }

    }
    public void Update()
    {
       if(trigger)
        {
            
        }
    }
}
