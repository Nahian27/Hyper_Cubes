using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;


public class MainMenu_Script : MonoBehaviour
{
    [EventRef]
    public string buttonSFX;

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
