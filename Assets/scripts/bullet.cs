using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float deathtime = 0f;
    private float deathtimestamp = 2f;
    public int damage = 1;
    void Update()
    {
       
        deathtime += Time.deltaTime;

       
        if (deathtime > deathtimestamp)
        {
            Destroy(gameObject); // Destroy the bullet GameObject.
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            collision.GetComponent<enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
