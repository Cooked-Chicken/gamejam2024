using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 direction;
    public float speed;
    [SerializeField]
    private int recruiting;
    public float recruitingDistance;

    void Start()
    {
        recruiting = 0;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        transform.Translate(direction * speed * Time.deltaTime);

    }

    public void RecruitingMore()
    {
        recruiting++;
    }

    public void RecruitingLess()
    {
        recruiting--;
    }

    public int isRecruiting()
    {
        return recruiting;
    }

}
