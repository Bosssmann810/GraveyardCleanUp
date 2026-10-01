using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerShoot : MonoBehaviour
{
    public GameObject blast;

    private bool canFire;
    private void Start()
    {
        canFire = true;
        blast.SetActive(false);
    }

    public IEnumerator Fire()
    {
        canFire = false;
        blast.SetActive (true);

        yield return new WaitForSeconds (0.5f);
        canFire = true;
        blast.SetActive(false);
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
