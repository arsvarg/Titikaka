using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 20;

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        EnemyHealthSystem enemy = hitinfo.GetComponent<EnemyHealthSystem>();

        if (enemy != null) {
            enemy.TakeDamage(damage);
            //Уничтожить выстреленную пулю
            Destroy(gameObject);
        }
        

        if (hitinfo.gameObject.tag == "Obstacle")
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
        if (Vector2.Distance(transform.position, FindObjectOfType<Player_movement>().gameObject.transform.position) > 50f)
        {
            Destroy(gameObject);
        }
    }
}
