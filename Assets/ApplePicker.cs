using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 4;          // now 4 baskets
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    [Header("Round UI")]
    public Text roundText;              // drag RoundText here in Inspector
    public GameObject restartButton;    // drag RestartButton here in Inspector

    [Header("Dynamic")]
    public List<GameObject> basketList;
    public int currentRound = 1;

    void Start()
    {
        // create the basket list
        basketList = new List<GameObject>();

        // spawn baskets
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }

        // initial round label
        if (roundText != null)
        {
            roundText.text = "Round " + currentRound;
        }

        // make sure restart button is hidden at start
        if (restartButton != null)
        {
            restartButton.SetActive(false);
        }
    }

    public void AppleMissed()
    {
        // Destroy all of the falling Apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tempGO in tAppleArray)
        {
            Destroy(tempGO);
        }

        // Destroy one of the Baskets
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        // If there are no Baskets left, GAME OVER
        if (basketList.Count == 0)
        {
            if (roundText != null)
            {
                roundText.text = "Game Over";
            }

            if (restartButton != null)
            {
                restartButton.SetActive(true);
            }

            // pause everything
            Time.timeScale = 0f;
        }
        else
        {
            // Go to the next round whenever you lose a basket
            currentRound++;
            if (currentRound > 4) currentRound = 4;  // cap at 4

            if (roundText != null)
            {
                roundText.text = "Round " + currentRound;
            }
        }
    }
    public void GameOver()
    {
        if (roundText != null)
        {
            roundText.text = "Game Over";
        }

        if (restartButton != null)
        {
            restartButton.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    // called by Restart button
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Scene_0");
    }
}
