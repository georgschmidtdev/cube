using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float timer;
    float miliseconds;
    float seconds;
    float minutes;

    bool start;

    [SerializeField] Text stopWatchText;
    void Start()
    {
        start = false;
        timer = 0; 
    }
    void Update()
    {
        StopWatchCalcul();
    }

    void StopWatchCalcul()
    {
        if (start)
        {
            timer += Time.deltaTime;
            miliseconds = (int)((timer * 100) % 100);
            seconds = (int)(timer % 60);
            minutes = (int)(timer / 60);
          
            stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("00");
        }
    }

    public void startTimer()
    {
        start = true;
    }

    public void stopTimer()
    {
        start = false;
    }

    public void resetTimer()
    {
        start = false;
        timer = 0;
        stopWatchText.text = "00:00:00";
    }
}
