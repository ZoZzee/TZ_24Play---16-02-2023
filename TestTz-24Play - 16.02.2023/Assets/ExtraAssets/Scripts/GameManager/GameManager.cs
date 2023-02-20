using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static bool GameOver = false;

    public TextMeshProUGUI textStart;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI textScore;
    public Button startButton;
    public Button restart;

    public static int score = 0;

    private bool cil = true;

    private void Start()
    {
        startButton.gameObject.SetActive(true);
        textStart.gameObject.SetActive(true);
        score = 0;
        UpdateScore(score);
    }

    void Update()
    {
        if (GameOver == true && cil == false)
        {
            restart.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
            cil = true;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOver = false;
        cil= false;
        score = 0;
    }

    public void UpdateScore( int num)
    {
        score += num;
        textScore.text = "Score: " + score;
    }

    public void StartGame()
    {
        Debug.Log(" ** ** * **");
        GameOver = false;
        cil= false;
        textStart.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
    }
}
