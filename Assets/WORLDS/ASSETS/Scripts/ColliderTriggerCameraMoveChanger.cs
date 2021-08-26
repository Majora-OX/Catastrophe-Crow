using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriggerCameraMoveChanger : MonoBehaviour
{
    public Camera maincam;
    public bool switchit;
    public float speed = 10f;
    public Transform fixorigin;
    public Transform target;
    public float lookatspeed = 5f;
    public Transform lookat;

    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            maincam.GetComponent<MoveToTarget3>().switched = switchit;
            maincam.GetComponent<MoveToTarget3>().speed = speed;
            maincam.GetComponent<MoveToTarget3>().fixorigin = fixorigin;
            maincam.GetComponent<MoveToTarget3>().target = target;
            maincam.GetComponent<MoveToTarget3>().lookatspeed = lookatspeed;
            maincam.GetComponent<MoveToTarget3>().lookat = lookat;
        }

    }
  
}


