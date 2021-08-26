using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriggerAppearMUTE : MonoBehaviour
{
    public GameObject target;
    public AudioSource phone;
    public GameObject crow;
    public GameObject cube9;
    AudioSource[] audiosource;
    public AudioSource Camera;




    private void Start()
    {
        audiosource = crow.GetComponents<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.name == "Crow")
        {
            target.gameObject.SetActive(true);
            cube9.gameObject.SetActive(false);
            phone.Stop();
            Camera.mute = true;
            audiosource[0].mute = true;
            audiosource[1].mute = true;
            audiosource[2].mute = true;
            audiosource[3].mute = true;

        }

    }
  
}


