using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoLevelChange : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Player;
    public bool open;
    public GameObject atmos;
    public AudioSource woosh;

    public AudioSource outrosound;
    public int desiredlevel;
    public float timer;
    public bool triggered;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Canvas.SetActive(true);
            atmos.GetComponent<CameraController>().lockingOn.allowLockingOn = false;
            Canvas.GetComponent<Animator>().SetBool("CLOSE", true);
            woosh.Play();
            outrosound.Play(1);
            
            Player.GetComponent<PlayerController>().enabled = false;
            Player.GetComponent<AudioSource>().enabled = false;
            triggered = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }

    }
    void Update()
    {
        if (Canvas.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DONE"))
        {
            atmos.GetComponent<AudioSource>().mute = true;
            SceneManager.LoadScene(desiredlevel, LoadSceneMode.Single);
        }
    }
}
