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
        "CubeGame"
    };

    private string[] sceneSelectors =
    {

        "startMainMenu",
        "startTutorial",
        "CubeGame"
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
