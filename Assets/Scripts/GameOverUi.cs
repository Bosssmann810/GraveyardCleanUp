using UnityEngine;
using TMPro;
public class GameOverUi : MonoBehaviour
{
    public StopWatch stopWatch;
    public GameObject gameOverScreen;
    public TextMeshProUGUI timeSurvivedText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    public void GameOver()
    {
        stopWatch.StopStopWatch();
        gameOverScreen.SetActive(true);
        timeSurvivedText.text = $"You Survived for {Mathf.FloorToInt(stopWatch.elapsedTime / 60)} minutes and {Mathf.FloorToInt(stopWatch.elapsedTime % 60)} seconds";
        Time.timeScale = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
