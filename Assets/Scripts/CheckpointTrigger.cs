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
    [SerializeField] Text Gyro1Interim1;
    [SerializeField] Text Gyro1Interim2;
    [SerializeField] Text Gyro1Interim3;
    [SerializeField] Text Gyro1Interim4;
    [SerializeField] Text Gyro1Interim5;
    [SerializeField] Text Gyro2Interim1;
    [SerializeField] Text Gyro2Interim2;
    [SerializeField] Text Gyro2Interim3;
    [SerializeField] Text Gyro2Interim4;
    [SerializeField] Text Gyro2Interim5;
    [SerializeField] Text Gyro3Interim1;
    [SerializeField] Text Gyro3Interim2;
    [SerializeField] Text Gyro3Interim3;
    [SerializeField] Text Gyro3Interim4;
    [SerializeField] Text Gyro3Interim5;
    [SerializeField] Text Gyro4Interim1;
    [SerializeField] Text Gyro4Interim2;
    [SerializeField] Text Gyro4Interim3;
    [SerializeField] Text Gyro4Interim4;
    [SerializeField] Text Gyro4Interim5;
    [SerializeField] Text Gyro5Interim1;
    [SerializeField] Text Gyro5Interim2;
    [SerializeField] Text Gyro5Interim3;
    [SerializeField] Text Gyro5Interim4;
    [SerializeField] Text Gyro5Interim5;
    [SerializeField] Text Gyro6Interim1;
    [SerializeField] Text Gyro6Interim2;
    [SerializeField] Text Gyro6Interim3;
    [SerializeField] Text Gyro6Interim4;
    [SerializeField] Text Gyro6Interim5;



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
            Gyro1Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
            Gyro2Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
            Gyro3Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
            Gyro4Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
            Gyro5Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
            Gyro6Interim1.text = "Cube 1: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 2) {
            Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro1Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro2Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro3Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro4Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro5Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
            Gyro6Interim2.text = "Cube 2: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 3) {
            Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro1Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro2Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro3Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro4Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro5Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
            Gyro6Interim3.text = "Cube 3: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 4) {
            Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro1Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro2Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro3Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro4Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro5Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
            Gyro6Interim4.text = "Cube 4: " + PlayerPrefs.GetString("currentTime");
        } else if (checkpointNumber == 5) {
            Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro1Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro2Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro3Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro4Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro5Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
            Gyro6Interim5.text = "Cube 5: " + PlayerPrefs.GetString("currentTime");
        }        
    }



}
