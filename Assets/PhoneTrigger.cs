using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTrigger : MonoBehaviour
{
    public AudioSource phone;
    public GameObject Camera;
    public AudioSource phone2;
    private float timer;
    public bool triggered;
    private bool triggered2;
    public GameObject gate;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (entered && !triggered)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                phone.Play();
                triggered = true;
                Camera.GetComponent<Camera>().depth = 1;
                Camera.GetComponent<Animator>().SetBool("active", true);
                gate.SetActive(true);
            }
        }
        if(triggered && Camera.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DONE") && !triggered2)
        {
            phone.Stop();
            phone2.Play();
            Camera.GetComponent<Camera>().depth = -1;
            triggered2 = true;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
        {
            entered = true;
            
        }

    }
}
