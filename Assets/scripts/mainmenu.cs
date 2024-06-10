
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    
    public void GoToMain(string sceanname)
    {
        SceneManager.LoadScene(sceanname);
    }
}
