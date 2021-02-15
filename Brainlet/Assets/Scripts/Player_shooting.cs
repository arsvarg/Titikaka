using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shooting : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] float bulletForce;
    [SerializeField] Transform[] firePoints;
    public GameObject bulletPrefab;
    Player_movement player_movement;
    public float fireRate = 2f;
    float nextShootTime;
    

    int chosenWeapon = 1;

    void Start()
    {
        player_movement = FindObjectOfType<Player_movement>();
        
    }

    void Update()
    {
        if (Time.time >= nextShootTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot(chosenWeapon);
                nextShootTime = Time.time + 1f / fireRate;

            }

        }



        if (Input.GetKeyDown("1"))
        {
            player_movement.directionOffset = 0f;
            chosenWeapon = 1;
        }

        if (Input.GetKeyDown("2"))
        {
            player_movement.directionOffset = 60f;
            chosenWeapon = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            player_movement.directionOffset = 120f;
            chosenWeapon = 3;
        }
        if (Input.GetKeyDown("4"))
        {
            player_movement.directionOffset = 180f;
            chosenWeapon = 4;
        }
        if (Input.GetKeyDown("5"))
        {
            player_movement.directionOffset = -120f;
            chosenWeapon = 5;
        }
        if (Input.GetKeyDown("6"))
        {
            player_movement.directionOffset = -60f;
            chosenWeapon = 6;
        }
    }

    void Shoot(int chosenWeapon)
    {
        if (chosenWeapon == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[0].position, firePoints[0].rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firePoints[0].up * bulletForce, ForceMode2D.Impulse);
        }

        if (chosenWeapon == 2)
        {
            Debug.Log("No weapon here!");
        }
        if (chosenWeapon == 3)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[2].position, firePoints[2].rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firePoints[2].up * bulletForce, ForceMode2D.Impulse);
        }
        if (chosenWeapon == 4)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[3].position, firePoints[3].rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firePoints[3].up * bulletForce, ForceMode2D.Impulse);
        }
        if (chosenWeapon == 5)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[4].position, firePoints[4].rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firePoints[4].up * bulletForce, ForceMode2D.Impulse);
        }
        if (chosenWeapon == 6)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoints[5].position, firePoints[5].rotation);
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(firePoints[5].up * bulletForce, ForceMode2D.Impulse);
        }




    }
}
