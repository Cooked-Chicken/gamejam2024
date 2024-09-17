using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pauseButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressedB = false;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressedB) 
        {
           pauseScreen.SetActive(true);
           isPressedB = false;
           Time.timeScale = 0;
        }
    }

    //when pauseButton is pressed
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) 
    {
        isPressedB = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) 
    {
        isPressedB = false;
    }
}
