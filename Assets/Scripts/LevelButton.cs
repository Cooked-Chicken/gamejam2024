using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    public void tasto_menu()
    {
        SceneManager.LoadSceneAsync(0);
    }


    public void tasto_play()
    {
        SceneManager.LoadSceneAsync(1);
    }


    public void tasto_quit()
    {
        Application.Quit();
    }

}
