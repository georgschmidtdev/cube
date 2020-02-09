using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	GameObject[] pauseObjects;

	// Use this for initialization
	void Start()
	{
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Update is called once per frame
	void Update()
	{

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
				unlockCursor();
				
			}
			else if (Time.timeScale == 0)
			{
				Debug.Log("high");
				Time.timeScale = 1;
				hidePaused();
				lockCursor();
				
			}
		}
	}

	//controls the pausing of the scene
	public void pauseControl()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
			hidePaused();
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused()
	{
		foreach (GameObject g in pauseObjects)
		{
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused()
	{
		foreach (GameObject g in pauseObjects)
		{
			g.SetActive(false);
		}
	}

	public void onClicked(Button button)
	{
		if (button.tag == "QuitGame")
		{
			Debug.Log("Quit");
			Application.Quit();
		}
		if (button.tag == "Resume")
		{
			lockCursor();
			hidePaused();
			Time.timeScale = 1;

		}
		
	}

	public void unlockCursor ()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		GameObject.Find("Player").GetComponent<CPMPlayer>().enabled = false;
	}

	public void lockCursor ()
	{
		GameObject.Find("Player").GetComponent<CPMPlayer>().enabled = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
