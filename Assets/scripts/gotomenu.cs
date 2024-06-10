
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomenu : MonoBehaviour
{
    public void GoTomenu(string sceanname)
    {
        SceneManager.LoadScene(sceanname);
    }
}
