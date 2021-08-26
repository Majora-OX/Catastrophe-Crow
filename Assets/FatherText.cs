using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FatherText : MonoBehaviour
{
    public Text message;
    private float Timer = 3;
    private float timePerCharacter = 0.2f;
    private int messageIndex = 0;
    public AudioSource textaudio;
    private bool played = false;
    private float Timer2 = 0;
    public GameObject background;
    public AudioSource ohfuck;
    public AudioSource Typing;
    private bool played2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
             
            Timer += timePerCharacter;
            messageIndex++;
            message.text = "H WQ HT ROEE".Substring(0, messageIndex);
            if (!played) { textaudio.Play(1); background.SetActive(true); played = true; }
        }
        if (message.text == "H WQ HT ROEE")
        {
            Timer2 += Time.unscaledDeltaTime;
           
            if (Timer2 >= 3 && !played2)
            {
                Typing.Stop();
                ohfuck.Play();
                Time.timeScale = 0;
                //SceneManager.LoadScene(2, LoadSceneMode.Single);
                played2 = true;
            }
            if (Timer2 >= 6)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(7, LoadSceneMode.Single);
            }
        }



    }
}
