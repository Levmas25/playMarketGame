using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public AudioSource click;
    public void MenuStart()
    {
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MenuExit()
    {
        Debug.Log("Game close");
        Application.Quit();
        click.Play();
    }
    public void Pause()
    {
        click.Play();
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        click.Play();
        Time.timeScale = 1f;
    }
    public void ExitMenu()
    {
        click.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SecondLvl()
    {
        SceneManager.LoadScene(2);
    }
}
