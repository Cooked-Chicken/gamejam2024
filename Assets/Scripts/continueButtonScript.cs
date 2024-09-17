using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class continueButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressedC = false;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressedC) 
        {
           pauseScreen.SetActive(false);
           isPressedC = false;
           Time.timeScale = 1;
        }
    }

    //when pauseButton is pressed
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData) 
    {
        isPressedC = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) 
    {
        isPressedC = false;
    }
}
