using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetActivate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        target.GetComponent<MoveToTarget2>().enabled = true;
    }

 
}
