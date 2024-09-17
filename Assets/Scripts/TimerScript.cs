using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 10;
    public int timeInt;
    public Text timerText;
    public Text cultists;
    //public static string cultistToWin;
    //numero minimo di cultisti da ottenere per vincere
    public int winNumber = 5000;

    void Start()
    {

    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timeInt = (int) timeRemaining;
            timerText.text = timeInt.ToString();
            if(int.Parse(cultists.text) < winNumber)
            SceneManager.LoadScene(2); //vittoria
        } else {
            SceneManager.LoadScene(4); //sconfitta
        }
    }
}