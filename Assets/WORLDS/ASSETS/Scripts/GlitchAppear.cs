using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchAppear : MonoBehaviour
{
    public GameObject target;




    private void Start()
    {
        target.gameObject.SetActive(true);
    }

}


