using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    private Rigidbody2D rb;
    float movehori;
    float moveverti;
    public float speed;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        //movehori = Input.GetAxisRaw("Horizontal");
        //moveverti = Input.GetAxisRaw("Vertical");
        /* if (movehori > 0)
         {
              gameObject.transform.localScale = new Vector3(1, 1, 1);
         }
         if (movehori < 0)
         {
             gameObject.transform.localScale = new Vector3(-1, 1, 1);
         }*/

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.localScale = new Vector3(1, 2, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.localScale = new Vector3(1, -2, 1);
        }





    }
}
/*if (Input.GetKeyDown(KeyCode.UpArrow))
{
    moveiny = 1;
}
if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    moveinx = -1;
}
if (Input.GetKeyDown(KeyCode.RightArrow))
{
    moveinx = 1;

}
if (Input.GetKeyDown(KeyCode.DownArrow))
{
    moveiny = -1;
}
if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
{
    moveiny = 0;
}
if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
{
    moveinx = 0;
}*/