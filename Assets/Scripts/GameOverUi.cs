using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
public class GameOverUi : MonoBehaviour
{
    public StopWatch stopWatch;
    public GameObject gameOverScreen;
    public TextMeshProUGUI timeSurvivedText;
    public GameObject player;
    private PlayerInput pI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
        pI = player.GetComponent<PlayerInput>();
    }

    public void GameOver()
    {
        stopWatch.StopStopWatch();
        gameOverScreen.SetActive(true);
        timeSurvivedText.text = $"You Survived for {Mathf.FloorToInt(stopWatch.elapsedTime / 60)} minutes and {Mathf.FloorToInt(stopWatch.elapsedTime % 60)} seconds";
        Time.timeScale = 0f;
        pI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
