using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int initialHealth;
    public int lives;
    public float speed;
    public int health;
    public Rigidbody2D player;
    //public GameObject gameOverUI;

    void Start()
    {
        health = initialHealth;
    }

    void Update()
    {
        if ( player.position.y < -5f)
        {
            health = 0;
            
        }

        if (health <= 0 && lives > 1)
        {
            lives -= 1;
            FindObjectOfType<LiveScore>().SubstractLive();
            health = initialHealth;
            //Destroy(gameObject);
            //FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Respawn>().RespawnPlayer();
        }
        else if(health <= 0 && lives == 1)
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
            //gameOverUI.SetActive(true);
        }

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player takes damage!");
    }
}
