using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class gameover : MonoBehaviour
{
   // public Text points;
  //  public TextMeshProUGUI points;

   
    public void setup(int score,string name)
    {
        gameObject.SetActive(true);
       // points.text = score.ToString() + " POINTS " + name;
       // points.text = score.ToString() + " POINTS" + name;
    }
    
}
