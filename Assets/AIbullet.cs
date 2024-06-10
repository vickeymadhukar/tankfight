using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float speed;

    private float deathtime = 0f;
    private float deathtimestamp = 2f;
    public int damage = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("enemy");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    // Update is called once per frame
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
