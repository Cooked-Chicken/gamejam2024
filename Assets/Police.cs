using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Police : MonoBehaviour
{
    public Player player;
    public GameManager gameManager;
    private Vector2 playerDirection;
    public float initialMoveSpeed;
    public float initialWatchDistance;
    Vector2 randomPos;

    [Header("Check stats")]
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float watchDistance;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRandomPosition", 0, 2);
        InvokeRepeating("updateStats", 3, 1);
        moveSpeed = initialMoveSpeed;
        watchDistance = initialWatchDistance;
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = player.transform.position - transform.position;


        if (playerDirection.magnitude < watchDistance)
        {
            WalkToPlayer(player.transform.position);
        }
        else
        {
            WalkRandomly(randomPos);
        }
    }

    private void WalkToPlayer(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
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

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (player.isRecruiting() > 0)
            {
                Debug.Log("GAME OVER !!!");
                Time.timeScale = 0;
                SceneManager.LoadScene(3); 
            }
        }
    }

    public void updateStats()
    {
        moveSpeed = initialMoveSpeed * (gameManager.GetCultists() * .1f + 1);
        watchDistance = initialWatchDistance * (gameManager.GetCultists() * .2f + 1);
    }
}
