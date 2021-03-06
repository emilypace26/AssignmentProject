﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;
    
        if (bullet.position.y >=10)
        Destroy (gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RedEnemy") 
        {
            PlayerScore playerScore = GameObject.Find("Score").GetComponent<PlayerScore>();
            if(playerScore != null)
            {
                playerScore.IncremenScoreRed();
            }
            Destroy(other.gameObject);
            Destroy (gameObject);
            
        }
        if (other.tag =="GreenEnemy")
        {
            PlayerScore playerScore = GameObject.Find("Score").GetComponent<PlayerScore>();
            if(playerScore != null)
            {
                playerScore.IncremenScoreGreen();
            }
            Destroy(other.gameObject);
            Destroy (gameObject);
        }
        if (other.tag == "BlueEnemy")
        {
            PlayerScore playerScore = GameObject.Find("Score").GetComponent<PlayerScore>();
            if(playerScore != null)
            {
                playerScore.IncremenScoreBlue();
            }
            Destroy(other.gameObject);
            Destroy (gameObject);
        }
    }
    
    }
