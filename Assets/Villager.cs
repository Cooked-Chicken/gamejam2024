/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Villager : MonoBehaviour
{
    public Player player;
    private Vector2 playerDirection;
    public GameManager gameManager;
    public Slider slider;
    public float initialTimer;
    [SerializeField]
    private float timeRemaining;
    public float moveSpeed;
    Vector2 randomPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRandomPosition", 0, 2);
        timeRemaining = initialTimer;
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = player.transform.position - transform.position;
        SetHealth();

        WalkRandomly(randomPos);

        if (gameObject.tag == "Villager" && playerDirection.magnitude < player.recruitingDistance)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            if (timeRemaining <= 0)
            {
                BecomeCultist();
            }
        }

    }

    private void WalkRandomly(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
    }

    private void MakeRandomPosition()
    {
        float xPos = Random.Range(-15f, 15f);
        float yPos = Random.Range(-15f, 15f);
        randomPos = new Vector2(xPos, yPos);
    }

    private void BecomeCultist()
    {
        gameObject.tag = "Cultist";
        gameObject.GetComponent<Renderer>().material.color = new Color(202, 0, 0);
        gameManager.GetComponent<GameManager>().ReduceVillagers();
    }

    public void ResetTimer()
    {
        timeRemaining = initialTimer;
    }

    private void SetHealth()
    {
        slider.value = 1 - timeRemaining / initialTimer;
    }
}
*/