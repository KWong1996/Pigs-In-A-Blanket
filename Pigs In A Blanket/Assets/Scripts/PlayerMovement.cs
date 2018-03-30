using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement: MonoBehaviour {

	public float speed;


    public Text scoreText;
    public Text truffleCount;
    public Text inventoryWeight;

    public int score = 0;
    public int weight = 0;

    public int numTruffles = 0;

	private Rigidbody2D rb2d;

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal,moveVertical);
		rb2d.AddForce (movement * speed);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Truffle"))
        {
            numTruffles++;
            weight++;
            inventoryWeight.text = weight + "/100";
            truffleCount.text = numTruffles.ToString();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Chest"))
        {   
            score += numTruffles;
            numTruffles = 0;
            weight = 0;
            inventoryWeight.text = weight + "/100";
            truffleCount.text = numTruffles.ToString();
            UpdateScore();

        }

    }


    void UpdateScore()
    {   
        scoreText.text = "Score: " + score;
    }
}
