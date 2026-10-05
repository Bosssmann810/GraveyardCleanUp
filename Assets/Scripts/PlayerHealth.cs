using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHp;
    private bool canGetHit = true;
    public DialougeMnager dialougeMnager;
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
        if (currentHp <= 0)
        {
            Debug.Log("dead");
            //add game over stuff here
        }
    }
}
