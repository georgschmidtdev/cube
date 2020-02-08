using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerStartTrigger : MonoBehaviour
{
    public Timer timerTrigger;
    
    private void OnTriggerEnter(Collider other)
    {
            timerTrigger.resetTimer();
            timerTrigger.startTimer();
    }
}


