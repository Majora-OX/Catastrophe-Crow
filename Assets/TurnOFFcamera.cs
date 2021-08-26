using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOFFcamera : MonoBehaviour
{
    public GameObject MainCamera;
    public bool on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!on)
        {
            MainCamera.GetComponent<MoveToTarget3>().enabled = false;
        }
        else { MainCamera.GetComponent<MoveToTarget3>().enabled = true; }
    }
}
