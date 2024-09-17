using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public int level;
    public int villagers;
    private int cultists = 0;


    // Update is called once per frame
    void Update()
    {
        if (villagers == 0)
        {
            Debug.Log("Vittoria!");
            Time.timeScale = 0;
            //TODO: VITTORIA
        }
    }

    public int GetCultists()
    {
        return cultists;
    }

    public void ReduceVillagers()
    {
        villagers--;
        cultists++;
    }
}
