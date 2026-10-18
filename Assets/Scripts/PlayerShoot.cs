using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerShoot : MonoBehaviour
{
    public GameObject blast;
    public AudioClip blastSound;
    public AudioSource playerAudio;
    private bool canFire;
    public ParticleSystem blastParticles;
    private void Start()
    {
        canFire = true;
        blast.SetActive(false);
    }

    public IEnumerator Fire()
    {
        canFire = false;
        blast.SetActive (true);
        playerAudio.clip = blastSound;
        blastParticles.Play();
        playerAudio.Play();
        yield return new WaitForSeconds (0.25f);
        
        blast.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        canFire = true;
        StopCoroutine(Fire());
    }

    public void OnFire()
    {
        if(canFire)
        {
           StartCoroutine(Fire());
        }
    }
}
