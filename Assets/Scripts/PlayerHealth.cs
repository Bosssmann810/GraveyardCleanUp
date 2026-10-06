using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHp;
    private bool canGetHit = true;
    public DialougeMnager dialougeMnager;
    public GameOverUi gameOverUi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHP;
    }

    IEnumerator GetHit()
    {
        canGetHit = false;
        currentHp -= 1;
        Debug.Log("Hit");
        dialougeMnager.HitInsault();
        GameOverCheck();
        yield return new WaitForSeconds(3);
        canGetHit=true;
        Debug.Log("can get hit again");
        StopCoroutine(GetHit());
    }

    public void TakeDamage()
    {
        if(canGetHit)
        {
            StartCoroutine(GetHit());

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void GameOverCheck()
    {
        if(currentHp <= 0)
        {
            gameOverUi.GameOver();
        }
    }
}
