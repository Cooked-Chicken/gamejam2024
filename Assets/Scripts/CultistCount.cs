using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CultistCounter : MonoBehaviour
{
    public static CultistCounter Instance;

    public TMP_Text cultistText;
    public int currentCultist = 0;


    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        cultistText.text = currentCultist.ToString();
    }

    public void IncreaseCultist(int v)
    {
        currentCultist += v;
        cultistText.text = currentCultist.ToString();
    }


}

