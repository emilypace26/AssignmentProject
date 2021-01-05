using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Transform playerTransform;
public float speed;
public float maxBound, minBound;

    //Bullet creation
    public GameObject bulletFired;
    public float fireRate;
    private float nextFire;


    // Start is called before the first frame update
    void Start()
    {
    playerTransform = GetComponent<Transform> ();
    }

    

    // Update is called once per frame
    void update()
    {
        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            Instantiate(bulletFired, playerTransform.position, playerTransform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
    
    void FixedUpdate()
    // maximum and minimum bound of player when moving
    {
        float h = Input.GetAxis("Horizontal");{
            if(playerTransform.position.x < minBound && h < 0)
        h = 0;
        else if (playerTransform.position.x > maxBound && h > 0)
        h = 0;
        }
        
        playerTransform.position += Vector3.right * h * speed;
        }
}