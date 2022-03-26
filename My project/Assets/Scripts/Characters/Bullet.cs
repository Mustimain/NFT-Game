using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rigidBody;
    public Character character;
    public Enemy enemy;

    void Start()
    {

        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        EnemyScript enemyScript = collision.GetComponent<EnemyScript>();

        if (collision.tag == "Enemy")
        {
            enemyScript.TakeDamage(character.attack);
            Debug.Log(enemy.name);
            Destroy(gameObject);
        }


    }
}
