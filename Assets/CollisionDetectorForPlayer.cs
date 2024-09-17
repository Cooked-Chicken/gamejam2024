using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectorForPlayer : MonoBehaviour
{
    void Start()
    {
        GetComponent<CircleCollider2D>().radius = transform.parent.GetComponent<Player>().recruitingDistance;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Villager"))
        {
            transform.parent.GetComponent<Player>().RecruitingMore();
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Villager"))
        {
            transform.parent.GetComponent<Player>().RecruitingLess();
        }
        if (coll.CompareTag("Cultist"))
        {
            transform.parent.GetComponent<Player>().RecruitingLess();
        }
    }
}
