using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Enemy enemy;
    public Character character;
    public GameObject patrol;


    private void Start()
    {
        enemy.health = 100;
    }


    public void TakeDamage(int takeDamage)
    {
        enemy.health -= takeDamage;

        if (enemy.health <= 0)
        {
            Die();
            character.currentScore += 1;
            character.totalScore += 1;
            Destroy(patrol);
            
        }
    }

    private void Die()
    {
        Instantiate(gameObject,transform.position,Quaternion.identity);
        Destroy(gameObject);

    }
}
