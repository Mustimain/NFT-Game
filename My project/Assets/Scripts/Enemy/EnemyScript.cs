using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Enemy enemy;
    public Character character;
    public Animator animator;
    private int health;


    private void Start()
    {
        health = enemy.health;
    }


    public void TakeDamage(int takeDamage)
    {
        health -= takeDamage;

        if (health <= 0)
        {
            
            Die();
            character.score += 10;

        }
    }

    private void Die()
    {
        animator.SetTrigger("die");
        Destroy(gameObject,0.9f);  
    }


}
