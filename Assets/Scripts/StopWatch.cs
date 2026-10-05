using UnityEngine;
using TMPro;
public class StopWatch : MonoBehaviour
{
    public TextMeshProUGUI stopWatchText;
    public float elapsedTime;
    private bool isActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive == true)
        {
            elapsedTime += Time.deltaTime;
        }
        UpdateText();
    }

    public void UpdateText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        if (seconds < 10)
        {
            stopWatchText.text = $"{minutes}:0{seconds}";
        }
        else
        {
            stopWatchText.text = $"{minutes}:{seconds}";
        }
    }
    public void RefreshStopWatch()
    {
        elapsedTime = 0f;
    }

    public void StartStopWatch()
    {
        isActive = true;
    }
    public void StopStopWatch()
    {
        isActive = false;
    }
}
