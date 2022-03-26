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
        character.score = 0;
        character.health = 100;
        rb = GetComponent<Rigidbody2D>();
    }

    // Karakter olum tag? olan nesnelere t?klarsa oluyor
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            Die();
            
        }
    }

    // Karakter ölümü ve skor yazd?rma
    private void Die()
    {
        
        Destroy(gameObject);
        gameOverMenu.ScoreText(character.score);
    }

    // Karakter hasar yemesi
    public void TakeDamage(int damage)
    {
        character.health -= damage;

        if (character.health <= 0)
        {
            Die();
        }

    }


}
