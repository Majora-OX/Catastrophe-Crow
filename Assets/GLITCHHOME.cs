using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GLITCHHOME : MonoBehaviour
{
    public int desiredlevel;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(desiredlevel, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
