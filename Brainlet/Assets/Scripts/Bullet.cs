using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float bulletForce;
    [SerializeField] float fireRate;
    [SerializeField] float damage;

    Rigidbody2D rb;


    void Start()
    {
        FindObjectOfType<Player_shooting>().fireRate = fireRate;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
    }
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
        if (collision.gameObject.GetComponent<Box>())
        {
            collision.gameObject.GetComponent<Box>().TakeDamage(damage);
        }

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
