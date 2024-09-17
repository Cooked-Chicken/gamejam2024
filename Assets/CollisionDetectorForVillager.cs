using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectorForVillager : MonoBehaviour
{
    public GameObject canvas;
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            transform.parent.GetComponent<Villager>().ResetTimer();
            canvas.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if (transform.parent.tag == "Villager")
            {
                canvas.SetActive(true);
            }
        }
    }
}
