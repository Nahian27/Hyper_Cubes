using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused_Script : MonoBehaviour
{
    public HUD_Script timer;
    public CanvasGroup PauseCanasGroup;
    [FMODUnity.EventRef]
    public string buttonSFX;

    void OnEnable()
    {
        PauseCanasGroup.LeanAlpha(1, 0.5f).setIgnoreTimeScale(true);
    }

    public void resume()
    {
        PauseCanasGroup.LeanAlpha(0, 0.5f).setOnComplete(TimeResume).setIgnoreTimeScale(true);
        FMODUnity.RuntimeManager.PlayOneShot(buttonSFX);
    }

    void TimeResume()
    {
        gameObject.SetActive(false);
        timer.StartCoroutine("Timer");
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        FMODUnity.RuntimeManager.PlayOneShot(buttonSFX);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
