using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    private bool rotationStatus = false;

    public GameObject objectToMove;
    public float animationDuration;


    void Start()
    {
        Time.timeScale = 1;
    }


    public void onClicked(Button button){

        if(button.tag == "rotateRight"){

            StartCoroutine(RotateMenuCube(objectToMove, new Vector3(0, -90, 0), animationDuration));
            StartCoroutine(MoveMenuCube(objectToMove, new Vector3(0, 0, 5), animationDuration / 2));
        }
        else if(button.tag == "rotateLeft"){

            StartCoroutine(RotateMenuCube(objectToMove, new Vector3(0, 90, 0), animationDuration));
            StartCoroutine(MoveMenuCube(objectToMove, new Vector3(0, 0, 5), animationDuration / 2));
        }
        else if (button.tag == "rotateUp"){

            StartCoroutine(RotateMenuCube(objectToMove, new Vector3(90, 0, 0), animationDuration));
            StartCoroutine(MoveMenuCube(objectToMove, new Vector3(0, 0, 5), animationDuration / 2));
        }
        else if (button.tag == "rotateDown"){

            StartCoroutine(RotateMenuCube(objectToMove, new Vector3(-90, 0, 0), animationDuration));
            StartCoroutine(MoveMenuCube(objectToMove, new Vector3(0, 0, 5), animationDuration / 2));
        }
        else if (button.tag == "QuitGame")
        {
            Debug.Log("quiten");
            Application.Quit();
        }
    }

    IEnumerator RotateMenuCube(GameObject gameObjectToMove, Vector3 eulerAngle, float duration){

        if (rotationStatus){
            yield break;
        }

        rotationStatus = true;

        Vector3 newRotation = gameObjectToMove.transform.eulerAngles + eulerAngle;

        Vector3 currentRotation = gameObjectToMove.transform.eulerAngles;

        float counter = 0;
        while (counter < duration){

            counter += Time.deltaTime;
            gameObjectToMove.transform.eulerAngles = Vector3.Lerp(currentRotation, newRotation, counter / duration);
            yield return null;
        }
        rotationStatus = false;
    }

    IEnumerator MoveMenuCube(GameObject gameObjectToMove, Vector3 moveVector, float duration){

        Vector3 newPosition = gameObjectToMove.transform.position + moveVector;
        Vector3 currentPosition = gameObjectToMove.transform.position;

        float counter = 0;
        while (counter < duration){

            counter += Time.deltaTime;
            gameObjectToMove.transform.position = Vector3.Lerp(currentPosition, newPosition, counter / duration);
            StartCoroutine(MoveMenuCubeBack(gameObjectToMove, moveVector * -1, duration));
            yield return null;
        }
    }

    IEnumerator MoveMenuCubeBack(GameObject gameObjectToMove, Vector3 moveVector, float duration){

        Vector3 newPosition = gameObjectToMove.transform.position + moveVector;
        Vector3 currentPosition = gameObjectToMove.transform.position;

        float counter = 0;
        while (counter < duration){

            counter += Time.deltaTime;
            gameObjectToMove.transform.position = Vector3.Lerp(currentPosition, newPosition, counter / duration);
            yield return null;
        }
    }
}
