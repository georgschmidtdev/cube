using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTrigger : MonoBehaviour
{

    [SerializeField] Text Interim1;
    [SerializeField] Text Interim2;
    [SerializeField] Text Interim3;
    [SerializeField] Text Interim4;
    [SerializeField] Text Interim5;

    public Timer timerTrigger;
    //public PrintTimesToUI setString;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (gameObject.CompareTag("Checkpoint1"))
            {
                setString(1);

            }
            else if (gameObject.CompareTag("Checkpoint2"))
            {
                setString(2);
            }
            else if (gameObject.CompareTag("Checkpoint3"))
            {
                setString(3);
            }
            else if (gameObject.CompareTag("Checkpoint4"))
            {
                setString(4);
            }
            else if (gameObject.CompareTag("Checkpoint5"))
            {
                setString(5);
            }
        }
     }   
        public void setString(int checkpointNumber) 
    {
        if (checkpointNumber == 1) {
            Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 2) {
            Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 3) {
            Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 4) {
            Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 5) {
            Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
        }        
    }



}
