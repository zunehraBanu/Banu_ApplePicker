using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject startPanel;   // panel with Start button

    void Start()
    {
        // Pause game until Start is pressed
        Time.timeScale = 0f;

        if (startPanel != null)
        {
            startPanel.SetActive(true);
        }
    }

    public void OnStartButton()
    {
        // Hide start panel and start the game
        if (startPanel != null)
        {
            startPanel.SetActive(false);
        }

        Time.timeScale = 1f;
    }
}
