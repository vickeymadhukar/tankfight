using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIshoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulpos;
    public float shootingRange = 5f; // Set the shooting range in the Inspector
    private float timer;
    public int bulletDamage = 1;
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        // Check if the player is within shooting range
        if (timer > 2 && IsPlayerWithinRange())
        {
            fire();
            Debug.Log("Fired!");
            timer = 0;
        }
    }

    void fire()
    {
        Instantiate(bullet, bulpos.position, Quaternion.identity);
        bullet.GetComponent<AIbullet>().damage = bulletDamage;

    }

    bool IsPlayerWithinRange()
    {
        GameObject player = GameObject.FindGameObjectWithTag("enemy");

        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            return distance <= shootingRange;
        }

        return false;
    }
}
