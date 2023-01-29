using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class fier : MonoBehaviour
{
    public Transform shootingpoint;


    public GameObject goli;
    public int bulletDamage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            // GameObject newBullet =
            GameObject newBullet = Instantiate(goli, shootingpoint.position, transform.rotation);
            newBullet.GetComponent<goli>().damage = bulletDamage;
        }

        
    }
}
