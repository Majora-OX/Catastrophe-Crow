using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressedStart : MonoBehaviour
{
    public AudioSource sound1;
    public Animator Animator;
    public AudioSource sound2;
    private float Timer;
    private bool pressed;
    private string[] Code;
    private int index;
    private bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        Code = new string[] { "m", "a", "j", "o", "r", "a", "o", "x" };
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown && !activated)
        {
            // Check if the next key in the code is pressed
            if (Input.GetKeyDown(Code[index]))
            {
                // Add 1 to index to check the next key in the code
                index++;
               
            }
            // Wrong key entered, we reset code typing
            else
            {
                index = 0;
                
            }
        }
        if (index == Code.Length)
        {
            
            activated = true;
           

        }

        if (Animator.GetCurrentAnimatorStateInfo(0).IsName("PRESSSTARTFUCKER"))
        {
            if (Input.GetButtonDown("Start") || Input.GetButtonDown("A/Jump"))
            {
                Animator.SetBool("START", true);
                sound1.Play(0);
                sound2.Stop();
                pressed = true;


            }
        }
        if (pressed)
        {
            Timer += Time.deltaTime;
            if (Timer >= 1.7 && !activated)
            {
                SceneManager.LoadScene(1, LoadSceneMode.Single);
            } else if (Timer >= 1.7) { SceneManager.LoadScene(15, LoadSceneMode.Single); }
        }
    }
}
