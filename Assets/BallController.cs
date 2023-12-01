using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // detect collisions that end the game
        if (collision.gameObject.tag == "Lose")
        {
            Debug.Log("You Lose!");
        }

        if (collision.gameObject.tag == "Win")
        {
            Debug.Log("You Win!");
        }

        //push the ball a little bit left or right when it bounces off another sprite
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = velocity.x / 2 + UnityEngine.Random.Range(-0.2f, 0.2f);
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}