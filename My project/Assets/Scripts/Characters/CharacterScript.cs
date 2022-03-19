using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public Character character;
    public GameOverMenu gameOverMenu;
    


    void Start()
    {
        character.currentScore = 0;
        character.health = 100;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (character.health <= 0)
        {
            Die();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            Die();
            
        }
    }

    private void Die()
    {
        
        Destroy(gameObject);
        gameOverMenu.ScoreText(character.currentScore);
    }

    public void TakeDamage(int damage)
    {
        character.health -= damage;
    }


}
