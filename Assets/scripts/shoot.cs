using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private AudioSource firesound;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public float fireRate = 0.5f;
    private float nextFire = 0f;
    private Rigidbody2D rb;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            firesound.Play();
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = bulletSpawnPoint.right* bulletSpeed;
        Destroy(bullet, 5f);
    }
}
