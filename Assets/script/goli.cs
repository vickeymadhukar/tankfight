using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goli : MonoBehaviour
{

    private float deathtime = 0f;
    private float deathtimestamp = 2f;
    public int damage = 1;
    public float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        deathtime += 1 * Time.deltaTime;
        if (deathtime > deathtimestamp)
        {
            Destroy(gameObject);
            deathtime = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            collision.GetComponent<enemy>().TakeDamage(damage);
        }
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        var direction = Vector3.Reflect(rb.velocity.normalized,collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
        
    }*/
}
