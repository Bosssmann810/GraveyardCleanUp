using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth player;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        }
    }

    private void Update()
    {
        UpdateHearts();
    }

    public void UpdateHearts()
    {
        if(player.currentHp == 2)
        {
            heart3.SetActive(false);
        }
        if(player.currentHp == 1)
        {
            heart2.SetActive(false);
        }
        if(player.currentHp == 0)
        {
            heart1.SetActive(false);
        }
    }
}
