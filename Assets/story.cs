using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class story : MonoBehaviour
{
    public TextMeshProUGUI storyText;
    public Button leftButton;
    public Button rightButton;

    private int currentLevel = 1;

    void Start()
    {
        leftButton.onClick.AddListener(() => MakeDecision("left"));
        rightButton.onClick.AddListener(() => MakeDecision("right"));

        UpdateStory("Alex is in an enchanted forest. Choose wisely to guide Alex through the magical adventure!");
    }

    void MakeDecision(string direction)
    {
        if (currentLevel == 1)
        {
            if (direction == "left")
            {
                UpdateStory("Alex discovered a friendly fairy who guides the way!");
                currentLevel = 2;
            }
            else
            {
                UpdateStory("Oh no! Alex stumbled upon a mischievous goblin. Try again!");
            }
        }
        else if (currentLevel == 2)
        {
            if (direction == "left")
            {
                UpdateStory("Alex found a hidden bridge and crossed it safely. Congratulations, you won!");
            }
            else
            {
                UpdateStory("Oops! Alex encountered a tricky troll. Better luck next time!");
            }

            // Add a delay and then restart the game
            Invoke("RestartGame", 3f);
        }
    }

    void UpdateStory(string newStory)
    {
        storyText.text = newStory;
    }

    void RestartGame()
    {
        // Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
