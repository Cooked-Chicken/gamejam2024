using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class exitButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed) 
        {
            
           SceneManager.LoadScene(0); //inserire scena da caricare
        }
    }

    //when pauseButton is pressed
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) 
    {
        isPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) 
    {
        isPressed = false;
    }
}
