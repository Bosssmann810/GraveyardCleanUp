using JetBrains.Annotations;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool paused;
    public GameObject pauseUI;
    public GameObject playerRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paused = false;
        pauseUI.SetActive(false);
    }

    public void OnPause()
    {
        if (paused == false)
        {
            playerRotation.SetActive(false);
            Debug.Log("pausing");
            paused = true;
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
            return;
        }
        if (paused == true)
        {
            playerRotation.SetActive(true);
            paused = false;
            pauseUI.SetActive(false);
            Time.timeScale = 1f;
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
