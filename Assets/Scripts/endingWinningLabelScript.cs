using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endingWinningLabelScript : MonoBehaviour
{

    public Text label;
    public string cultistToWin;
    //public string cultists = TimerScript.cultistToWin;
    // Start is called before the first frame update
    void Start()
    {
        label.text = "Wow, it looks like you completed the level. Good Job!\nYour influence grown in the whole city!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
