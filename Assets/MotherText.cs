using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MotherText : MonoBehaviour
{
    public Text message;
    private float Timer = 1;
    private float timePerCharacter = 0.01f;
    private int messageIndex = 0;
    public AudioSource textaudio;
    private bool played = false;
    private float Timer2 = 0;
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
            if (message.text == "He's not been home for days.") { Timer = 1; }
            message.text = "He's not been home for days. Maybe he will talk with you...".Substring(0, messageIndex);
            if (!played) { textaudio.Play(1); played = true; }
        }
        if (message.text == "He's not been home for days. Maybe he will talk with you...")
        {
            Timer2 += Time.deltaTime;
            if (Timer2 >= 1)
            {
                SceneManager.LoadScene(2, LoadSceneMode.Single);
            }
        }



    }
}
