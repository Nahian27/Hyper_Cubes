using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOver_Script : MonoBehaviour
{
    public TextMeshProUGUI scoreText, highScoreText;
    public CanvasGroup GameOverGroup;
    public float Delay;
    [FMODUnity.EventRef]
    public string buttonSFX;
    [FMODUnity.EventRef]
    public string button2SFX;

    void OnEnable()
    {
        GameOverGroup.LeanAlpha(1, 1f).delay = Delay;
    }

    public void Setup(int score)
    {
        scoreText.text = "Score " + score.ToString();

        if(score>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        highScoreText.text = "Highest score " + PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene(1);
        FMODUnity.RuntimeManager.PlayOneShot(buttonSFX);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        FMODUnity.RuntimeManager.PlayOneShot(button2SFX);
    }
}
