using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerBombDrop : MonoBehaviour
{
    public Transform currentPlayerPos;
    public GameObject bomb;
    public GameObject newBomb;
    public float bombCoolDown;
    private bool bombOnCoolDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bombOnCoolDown = false;
    }
    public void BombButton()
    {
        if(bombOnCoolDown == false)
        {
            StartCoroutine(DropBomb());
        }
    }

    IEnumerator DropBomb()
    {
        Debug.Log("dropping bomb");
        bombOnCoolDown = true;
        newBomb = Instantiate(bomb, null);
        newBomb.transform.position = currentPlayerPos.position;
        yield return new WaitForSeconds(bombCoolDown);
        bombOnCoolDown = false;
    }
}
