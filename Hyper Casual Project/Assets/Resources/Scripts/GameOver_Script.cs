using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameOver_Script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public CanvasGroup GameOverGroup;
    public float Delay;

    void OnEnable()
    {
        GameOverGroup.LeanAlpha(1, 1f).delay = Delay;
    }

    public void Setup(int score)
    {
        scoreText.text = "Score " + score.ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
