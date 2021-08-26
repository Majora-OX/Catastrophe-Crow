using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownTrigger : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;

    void Start()
    {
        myAnimationController.SetBool("trig", true);
        myAnimationController2.SetBool("trig", true);
    }

   
}


