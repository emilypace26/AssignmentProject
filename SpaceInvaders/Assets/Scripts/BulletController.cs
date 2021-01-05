using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bulletTransform;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bulletTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            bulletTransform.position += Vector3.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RedEnemies")
        Destroy(other.gameObject);

        if (other.tag == "BlueEnemies")
        Destroy(other.gameObject);

        if (other.tag == "GreenEnemies")
        Destroy(other.gameObject);
    }


}
