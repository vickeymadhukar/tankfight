using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ENDING : MonoBehaviour
{
    public Text points;
    public void setup(int score, string name)
    {
        gameObject.SetActive(true);
        points.text = score.ToString() + " POINTS  " + name;
    }
}
