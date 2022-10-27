using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float jumpInterval;
    private Rigidbody2D rb;

    public float score;
    public TextMeshProUGUI scoreText;

    private GameManager gameManager;

    private float angle;
    private float minAngle = -10;
    private float maxAngle = 10;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }


    private void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpInterval;
        }
    }



    private void Nod()
    {
        if (rb.velocity.y > 0 && angle <= maxAngle)
        {
            angle += 4;          
        }
        else if (rb.velocity.y < -1.1 && angle > minAngle)
        {
            angle -= 2;
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Update()
    {
        Move();
       
    }


    private void FixedUpdate()
    {
        Nod();   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
        {
            if (collision.gameObject.CompareTag("ScoreManager"))
            {
                score++;
                scoreText.text = score.ToString();
            }
        }     
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            gameManager.GameOver();
        }
    }
}
