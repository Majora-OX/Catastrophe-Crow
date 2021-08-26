using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsceneSanscollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(11, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
