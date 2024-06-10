using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class countdown : MonoBehaviour
{
    public int countend;
    public TextMeshProUGUI count;
    public ratate rotatescript;
    public tank2move movemscript;
    private bool countdownActive = true;
    void Start()
    {
        movemscript.DisableMove();
        rotatescript.DisableMovement();
        StartCoroutine(countdownstart()); 
    }

    // Update is called once per frame
    IEnumerator countdownstart()
    {
        while (countend>0)
        {
            count.text = countend.ToString();
            yield return new WaitForSeconds(1f);
            countend--;
        }
        count.text = "";
        countdownActive = false;
        rotatescript.EnableMovement();
        movemscript.EnableMove();
    }
    
    
}