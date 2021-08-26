using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTriggerforest : MonoBehaviour
{
    public AudioSource phone;
    public AudioSource father;
    public AudioSource atmos;
    public GameObject toremove;
    
    public bool triggered;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
        {
            
            phone.Play();
            father.Stop();
            atmos.Stop();
            triggered = true;
            toremove.SetActive(false);
            
        }

    }
}
