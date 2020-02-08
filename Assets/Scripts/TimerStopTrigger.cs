using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerStopTrigger : MonoBehaviour
{
    public Timer timerTrigger;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            timerTrigger.stopTimer();
        }
            
    }
    
}


