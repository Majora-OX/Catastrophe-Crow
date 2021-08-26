using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    EventSystem m_EventSystem;
    public GameObject menupanel;
    private bool active = false;
    public GameObject crowfeet;
    private AudioSource open;
    private AudioSource close;
    public AudioClip menuResume;
    public GameObject button1;
    public GameObject pointer;
    public Text button2text;
    public Text button3text;
    public GameObject TurnCamera;

    // Start is called before the first frame update
    void Start()
    {
        open = gameObject.GetComponent<AudioSource>();

    }
    void Awake()
    {
        m_EventSystem = EventSystem.current;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start") && TurnCamera.GetComponent<CameraController>().lockingOn.allowLockingOn)
        {
            if (!active)
            {
                m_EventSystem.SetSelectedGameObject(button1);
               open.Play();
                crowfeet.GetComponent<AudioSource>().mute = true;
                crowfeet.GetComponent<PlayerController>().enabled = false;
                menupanel.SetActive(true);
                active = true;
                Time.timeScale = 0;
            }
            else
            {
                resume();

            }
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        Time.timeScale = 1;
    }
    public void resume()
    {
        button2text.text = "VIEW TOTALS";
        button3text.text = "HELP";
        pointer.GetComponent<pointer>().pos1();
        open.PlayOneShot(menuResume);
        crowfeet.GetComponent<AudioSource>().mute = false;
        menupanel.SetActive(false);
        active = false;
        Time.timeScale = 1;
        crowfeet.GetComponent<PlayerController>().enabled = true;
    }
}
