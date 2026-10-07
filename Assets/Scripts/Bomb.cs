using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Bomb : MonoBehaviour
{
    public GameObject blastRadius;
    public float fuseTime;
    public float exsplosionDuration;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       blastRadius.SetActive(false);
       StartCoroutine(Explode());
    }
    IEnumerator Explode()
    {
        yield return new WaitForSeconds(fuseTime);
        blastRadius.SetActive(true);
        yield return new WaitForSeconds(exsplosionDuration);
        Destroy(gameObject);
    }

}
