using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Transform player;
public float speed;
public float maxBound, minBound;

    //Bullet creation
    public GameObject shot;
    public float shotSpawn;
    public float fireRate;

    private float nextFire;


//use this instialization
    // Start is called before the first frame update
    void Start(){
        player = GetComponent<Transform> ();
    }

    void FixedUpdate()
    // maximum and minimum bound of player when moving
    {
        float h = Input.GetAxis("Horizontal");{
            if (player.position.x < minBound && h < 0)
        h = 0;
        else if (player.position.x > maxBound && h > 0)
        h = 0;
        }
            player.position += Vector3.right * h * speed;
    }
        void Update(){
        // if(Input.GetKeyDown(KeyCode.Space))
            if (Input.GetKeyDown("space")) {
        Instantiate (shot);
        Debug.Log("Space bar was pressed");}
        }
    
}



