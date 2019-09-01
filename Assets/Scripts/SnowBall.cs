using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float ballSpeed;

    private Rigidbody2D rigidbody2D;

    public GameObject snowBallEffect;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the direction of the snowball
        rigidbody2D.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Collision to hurt player 1
        if(collision.tag == "Player1")
        {
            FindObjectOfType<GameManager>().HurtP1();
        }

        //Collision to hurt player 2
        if (collision.tag == "Player2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }

        Instantiate(snowBallEffect, transform.position, transform.rotation); //Create Particle System Effect when it collides something
        Destroy(gameObject); //Destroy snowball when it hits something
    }
}
