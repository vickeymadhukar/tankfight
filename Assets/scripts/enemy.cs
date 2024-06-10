using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class enemy : MonoBehaviour
{
    public int health = 4;
    public string opponent;
    public GameObject deathani;
    public int noofhearth=0;
    public Image[] hearts;
   
    public gameover gamend;
    public void TakeDamage(int damage)
    {
        health -= damage;
        noofhearth = health;
        if (health <= 0)
        {
            Instantiate(deathani, transform.position, transform.rotation);
            Destroy(gameObject);
           
            GameOver(opponent);
        }
        else
        {
            // play hit animation
        }
    }
    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)//total health
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
            
        }
    }
    public void GameOver(string nam)
    {
        gamend.setup(1,nam);
    }
    
}


