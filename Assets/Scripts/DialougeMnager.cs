using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class DialougeMnager : MonoBehaviour
{
    public GameObject dialougeBox;
    public TextMeshProUGUI dialouge;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialougeBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HitInsault()
    {
        int insaultPicker = Random.Range(0, 10);
        Debug.Log(insaultPicker);
        if(insaultPicker == 0)
        {
            dialouge.text = "Careful now";
        }
        if(insaultPicker == 1)
        {
            dialouge.text = "Oof that's gotta sting";
        }
        if(insaultPicker == 2)
        {
            dialouge.text = "... That was just sad";
        }
        if(insaultPicker == 3)
        {
            dialouge.text = "What happened to that kill all monsters attitude?";
        }
        if(insaultPicker == 4)
        {
            dialouge.text = "You know, I almost feel bad for you... Almost";
        }
        if(insaultPicker == 5)
        {
            dialouge.text = "You're getting too old for this Father";
        }
        if(insaultPicker == 6)
        {
            dialouge.text = "Better step up your game or you're toast";
        }
        if(insaultPicker == 7)
        {
            dialouge.text = "Wow even Lerry managed to hit you?";
        }
        if(insaultPicker == 8)
        {
            dialouge.text = "You can quit whenever you want pal";
        }
        if(insaultPicker == 9)
        {
            dialouge.text = "Im actually impressed with how bad at this you are";
        }
        if(insaultPicker == 10)
        {
            dialouge.text = "Maybe its time to retire";
        }
        StartCoroutine(BringUpDailouge());
    }

    IEnumerator BringUpDailouge()
    {
        dialougeBox.SetActive(true);
        yield return new WaitForSeconds(3);
        dialougeBox.SetActive(false);
    }
}
