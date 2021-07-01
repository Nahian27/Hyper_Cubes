using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused_Script : MonoBehaviour
{
    public HUD_Script timer;
    public CanvasGroup PauseCanasGroup;

    void OnEnable()
    {
        PauseCanasGroup.LeanAlpha(1, 0.5f).setIgnoreTimeScale(true);
    }

    public void resume()
    {
        gameObject.SetActive(false);
        PauseCanasGroup.LeanAlpha(0, 0.5f).setOnComplete(TimeResume).setIgnoreTimeScale(true);
    }

    void TimeResume()
    {
        timer.StartCoroutine("Timer");
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
