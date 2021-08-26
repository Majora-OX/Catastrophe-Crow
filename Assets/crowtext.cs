using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crowtext : MonoBehaviour
{

    public bool total;
    public Text message;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scramble()
    {
        if (total)
        {
            message.text = "JHOS CLCWEA";

        }
        else
        {
            message.text = "ROEU";
        }
    }
}
