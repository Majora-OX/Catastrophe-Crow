using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ParticleMaterialChangeWithKeyPress : MonoBehaviour
{
    public Material newMat;
    public bool triggered = false;
 
 void Update()
    {
        if (triggered)
        {
            GetComponent<ParticleSystemRenderer>().material = newMat;
        }
    }

}