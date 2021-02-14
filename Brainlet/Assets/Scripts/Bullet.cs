using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        //Добавить рикошет?
    }

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
