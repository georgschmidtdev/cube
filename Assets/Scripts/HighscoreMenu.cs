using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreMenu : MonoBehaviour
{
    [SerializeField] Text highscores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscores.text = PlayerPrefs.GetString("Highscores");
    }
}
