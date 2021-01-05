using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Transform Player;
public float speed;
public float maxBound, minBound;


public GameObject shot;
public Transform shotSpawn;
public float fireRate;
private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
    Player = GetComponent<Transform> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    // maximum and minimum bound of player when moving
    {
        float h = Input.GetAxis("Horizontal");
        if(Player.position.x < minBound && h < 0)
        h = 0;
        else if (Player.position.x > maxBound && h > 0)
        h = 0;

        Player.position += Vector3.right * h * speed;
    }
}







