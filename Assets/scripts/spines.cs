using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spines : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            collision.GetComponent<enemy>().TakeDamage(damage);
             
        }
    }
}
