using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedTimer : MonoBehaviour
{
    public Text message;
    private float Timer = 0;
    private int minute = 00;
    private int second = 00;
    private int milisecond = 0;
    private string seconds;
    private string minutes;
    private string miliseconds;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi");
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("hi");
    }
        // Update is called once per frame
        void Update()
    {
        if (SceneManager.GetActiveScene().name == "INTRO") { Destroy(this.gameObject); }
        if (SceneManager.GetActiveScene().name != "HOME_V5")
        {
            Timer += Time.unscaledDeltaTime;
            milisecond = (int)((Timer - (int)Timer) * 100);
            second = (int)Timer % 60;
            minute = (int)Timer / 60;

            if (second < 10) { seconds = "0" + second.ToString(); } else { seconds = second.ToString(); }
            if (minute < 10) { minutes = "0" + minute.ToString(); } else { minutes = minute.ToString(); }
            if (milisecond < 10) { miliseconds = "0" + milisecond.ToString(); } else { miliseconds = milisecond.ToString(); }
            message.text = minutes + ":" + seconds + ":" + miliseconds;
        }
    }
}
