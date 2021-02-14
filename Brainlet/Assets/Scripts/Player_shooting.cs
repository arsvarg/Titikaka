using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shooting : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] float bulletForce;
    public GameObject bulletPrefab;

    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
