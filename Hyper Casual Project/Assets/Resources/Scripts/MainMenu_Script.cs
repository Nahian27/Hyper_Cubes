using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu_Script : MonoBehaviour
{
    [EventRef]
    public string buttonSFX;


    public void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
        RuntimeManager.PlayOneShot(buttonSFX);
    }
    public void quit()
    {
        Application.Quit();
    }
}
