using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchDisapear : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        target.gameObject.SetActive(false);
    }
   
  
}


