using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    private string[] scenes = 
    {

        "MainMenu",
        "Tutorial",
        "Lvl_1",
        "Lvl_2",
        "Lvl_3",
        "Lvl_4",
        "Lvl_5",
        "Lvl_6"
    };

    private string[] sceneSelectors =
    {

        "startMainMenu",
        "startTutorial",
        "startLvl_1",
        "startLvl_2",
        "startLvl_3",
        "startLvl_4",
        "startLvl_5",
        "startLvl_6"
    };

    public void onClicked(Button button){

        for (int i = 0; i < sceneSelectors.Length; i++)
        {
            if(button.tag == sceneSelectors[i]){
                print(scenes[i]);
                SceneManager.LoadScene(scenes[i], LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < sceneSelectors.Length; i++)
            {
                if (gameObject.tag == sceneSelectors[i])
                {
                    print(scenes[i]);
                    SceneManager.LoadScene(scenes[i], LoadSceneMode.Single);
                }
            }
        }
    }
}
