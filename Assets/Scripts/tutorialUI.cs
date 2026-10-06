using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class tutorialUI : MonoBehaviour
{
    public GameObject player;
    private PlayerInput pI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        pI = player.GetComponent<PlayerInput>();
        pI.enabled = false;
    }


    public void Begin()
    {
        Time.timeScale = 1f;
        pI.enabled=true;
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
