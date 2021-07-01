using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD_Script : MonoBehaviour
{
    public TextMeshProUGUI HudScoreText;
    public int score;
    private float scorePerSec;
    public GameOver_Script FinalScore;
    public GameObject PauseScreen;


    void Start()
    {
        score = 0;
        scorePerSec = 1f;
        StartCoroutine("Timer");
    }

    void OnGUI()
    {
        HudScoreText.text = score.ToString();
        FinalScore.Setup((int)score);
    }

    public void Paused()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(scorePerSec);
            score++;
        }

    }
}
