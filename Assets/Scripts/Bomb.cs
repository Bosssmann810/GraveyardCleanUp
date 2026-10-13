using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
public class Bomb : MonoBehaviour
{
    public GameObject blastRadius;
    public float fuseTime;
    public float exsplosionDuration;
    public AudioSource bombAudio;
    public AudioClip bombClip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       blastRadius.SetActive(false);
       StartCoroutine(Explode());
    }
    IEnumerator Explode()
    {
        yield return new WaitForSeconds(fuseTime);
        bombAudio.clip = bombClip;
        bombAudio.Play();
        blastRadius.SetActive(true);
        yield return new WaitForSeconds(exsplosionDuration);
        Destroy(gameObject);
    }

}
