using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void LoadEndlessMode()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void ReturntoMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
}
