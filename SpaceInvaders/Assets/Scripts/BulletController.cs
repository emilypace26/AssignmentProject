using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
private Transform Bullet;
public float Speed;

    // Start is called before the first frame update
    void Start() {
        Bullet = GetComponent<Transform> ();
    }

    void FixedUpdate(){
        Bullet.position += Vector3.up* Speed;

        if (Bullet.position.y >= 10)
            Destroy (gameObject);
    }
}










