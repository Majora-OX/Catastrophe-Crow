using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogactivator : MonoBehaviour
{
    public bool crash;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = true;
    }

    private void Update()
    {
        if (crash) { Application.Quit(); } 
    }

}
