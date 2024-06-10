using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    [SerializeField] private AudioSource firesound2;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public float fireRate = 0.5f;
    private float nextFire = 0f;
    public int bulletDamage = 1;
     
   
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            firesound2.Play();
            nextFire = Time.time + fireRate;
            Shoot();
        }

       
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = bulletSpawnPoint.right * bulletSpeed;
        bullet.GetComponent<bullet>().damage = bulletDamage;
        Destroy(bullet, 5f);
    }
}
