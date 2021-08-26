using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraMoveChanger : MonoBehaviour
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
        maincam.GetComponent<MoveToTarget3>().switched = switchit;
        maincam.GetComponent<MoveToTarget3>().speed = speed;
        maincam.GetComponent<MoveToTarget3>().fixorigin = fixorigin;
        maincam.GetComponent<MoveToTarget3>().target = target;
        maincam.GetComponent<MoveToTarget3>().lookatspeed = lookatspeed;
        maincam.GetComponent<MoveToTarget3>().lookat = lookat;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }

    }
  
}


