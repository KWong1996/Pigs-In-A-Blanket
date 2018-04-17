using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{

    public float speed = 42;

    public Text scoreText;
    public Text truffleCount;
    public Text inventoryWeight;

    public int score = 0;
    public int weight = 0;

    public int numTruffles = 0;

    public string horizontalcntrl = "Horizontal_P2";
    public string verticalcntrl = "Vertical_P2";

    public string powerUp_1 = "P2_PowerUp_1";
    public string powerUp_2 = "P2_PowerUp_2";

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis(horizontalcntrl);
        float moveVertical = Input.GetAxis(verticalcntrl);

        bool powerup_1 = Input.GetButtonDown(powerUp_1);
        bool powerup_2 = Input.GetButtonDown(powerUp_2);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);


        if (powerup_1)
        {
            Application.Quit();
        }
        if (powerup_2)
        {
            Application.Quit();
        }



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Truffle"))
        {
            numTruffles++;
            weight++;
            inventoryWeight.text = weight + "/40";
            truffleCount.text = numTruffles.ToString();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Chest"))
        {
            score += numTruffles;
            numTruffles = 0;
            weight = 0;
            inventoryWeight.text = weight + "/40";
            truffleCount.text = numTruffles.ToString();
            UpdateScore();

        }

    }


    void UpdateScore()
    {
        GameStats.player2Score = score;
    }
}
