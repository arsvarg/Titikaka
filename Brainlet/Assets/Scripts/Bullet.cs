using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, FindObjectOfType<Player_movement>().transform.position) > 50f)
        {
            Destroy(gameObject);
        }
    }
}
