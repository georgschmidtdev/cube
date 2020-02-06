using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Timer : MonoBehaviour
{

    float timer;
    float miliseconds;
    float seconds;
    float minutes;

    List<HighscoreEntry> HighscoreList = new List<HighscoreEntry>();
    List<HighscoreEntry> NewList = new List<HighscoreEntry>();

    bool start;

    [SerializeField] Text stopWatchText;
    [SerializeField] Text highscoreList;

    public struct HighscoreEntry{

        public float Min;
        public float Sec;
        public float Ms;
        
        public HighscoreEntry(float min, float sec, float ms){

        Min = min;
        Sec = sec;
        Ms = ms;
        }
    }
    
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

            PlayerPrefs.SetString("currentTime", stopWatchText.text);
        }
    }

    public void startTimer()
    {
        start = true;
    }


    public void stopTimer()
    {
        if(start){
            addHighscoreEntry();
        }
        start = false;
    }

    public void resetTimer()
    {
        start = false;
        timer = 0;
        stopWatchText.text = "00:00:00";
    }

    public void addHighscoreEntry(){
        HighscoreEntry entry = new HighscoreEntry(minutes, seconds, miliseconds);

        HighscoreList.Add(entry);

        NewList = HighscoreList.OrderBy(HighscoreList => HighscoreList.Min).ThenBy(HighscoreList => HighscoreList.Sec).ThenBy(HighscoreList => HighscoreList.Ms).ToList();
      
        drawHighscoreList();
        
    }

    public void drawHighscoreList(){

        string listString = "";

        int length = NewList.Count;

        for(int i = 0; i < length; i++){

            string stringMin = "";
            string stringSec = "";
            string stringMs = "";

            if(NewList[i].Min < 10 ) {
                stringMin = "0" + NewList[i].Min;
            } else {
                stringMin = NewList[i].Min.ToString();
            }

            if(NewList[i].Sec < 10 ) {
                stringSec = "0" + NewList[i].Sec;
            } else {
                stringSec = NewList[i].Sec.ToString();
            }

            if(NewList[i].Ms < 10 ) {
                stringMs = "0" + NewList[i].Ms;
            } else {
                stringMs = NewList[i].Ms.ToString();
            }

            string entryString = stringMin + ":" + stringSec + ":" + stringMs + "\n";
            listString = listString + entryString;
            
        }

        highscoreList.text = listString;
        PlayerPrefs.SetString("Highscores", listString);
    }
}
