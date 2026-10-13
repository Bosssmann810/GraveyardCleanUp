using UnityEngine;
using TMPro;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        loadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadHighScore()
    {
        if(File.Exists(Application.persistentDataPath + "/highScore.dat"))
        {
            Debug.Log("File found");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/highScore.dat", FileMode.Open);
            float highScore = (float)bf.Deserialize(file);
            file.Close();
            int minutes = Mathf.FloorToInt(highScore / 60);
            int seconds = Mathf.FloorToInt(highScore % 60);
            if (seconds < 10)
            {
                text.text = $"{minutes}:0{seconds}";
            }
            else
            {
                text.text = $"{minutes}:{seconds}";
            }
        }
        else
        {
            text.text = "0:00";
        }
    }
}
