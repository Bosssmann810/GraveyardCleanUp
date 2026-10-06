using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Enemy : MonoBehaviour
{

    public int enemyHp;
    public int enemyValue;
    public int enemyMoveSpeed;
    public Transform targetPos;
    public GameObject player;
    private bool canBeHit;
    public Director director;
    public bool isPossessed;
    public GameObject ghost;
    public GameObject newGhost;
    void Start()
    {
        canBeHit = true;
        player = GameObject.FindGameObjectWithTag("Player");
        targetPos = player.GetComponent<Transform>();
        director = GameObject.FindGameObjectWithTag("Director").GetComponent<Director>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos.position = player.GetComponent<Transform>().position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos.position, enemyMoveSpeed * Time.deltaTime);
        if(enemyHp <= 0)
        {
            //if ispossesed is ture the enemy will spawn a ghost on death (technically its not a ghost but sumantics.
            if(isPossessed == true)
            {
                Debug.Log("spawning Spirit");
                newGhost = Instantiate(ghost, null);
                newGhost.GetComponent<Transform>().position = gameObject.transform.position;
            }
            director.RetreaveCredits(enemyValue);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage();
        }   
    }

    IEnumerator TakeDamage()
    {
        canBeHit = false;
        enemyHp -= 1;
        Debug.Log("Hit enemy");
        yield return new WaitForSeconds(0.6f);
        canBeHit = true;
        Debug.Log("enemy can get hit again");
        StopCoroutine(TakeDamage());
    }


    public void Hit()
    {
        if(canBeHit)
        {
            StartCoroutine(TakeDamage());
        }
    }
}
