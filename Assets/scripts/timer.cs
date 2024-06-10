using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime=60.0f;
    private bool isGameRunning = true;
    private float currentTime;
    void Start()
    {
       
        currentTime = startTime;
    }


    private void Update()
    {
        if (isGameRunning)
        {
            currentTime -= Time.deltaTime;
            
            // Update the timer text
            string minutes = ((int)currentTime / 60).ToString();
            string seconds = (currentTime % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
            // Check if the timer has run out
            if (currentTime <= 0)
            {
                currentTime = 0;
                isGameRunning = false;
                // Implement game-over logic here (e.g., show a game over screen or end the game).
            }
        }
    }
    
}
