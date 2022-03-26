using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private Vector3 velocity;
    private float speedAmount = 5f;
    private float jumpAmount = 10f;
    private Animator animator;
    public GameObject player;

    void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Run();
        Jump();

    }


    void Run()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f,0f); ;


        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }


    void Jump()
    {
        // Karakter space basarsa ve z?plam?yorsa z?pl?yor
        if (Input.GetButtonDown("Jump") && !animator.GetBool("isJump"))
        {
            rigidBody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("isJump", true);
        }
        

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Karakter yer ile temas etti?inde z?plama an?masyonunu false yap?yor
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isJump", false);
        }

        // Karater Platforma bast?g?nda ve z?pl?yo ise z?plama an?masyonunu false yap?yor
        if (collision.gameObject.CompareTag("Platform") && animator.GetBool("isJump"))
        {
            animator.SetBool("isJump", false);

            // karakter platformla ayn? anda hareket ed?yo
            player.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        // karakter yerle temas? kes?ld?g?nde z?plama an?masyonunu aktif hale getiriyo
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isJump", true);
        }

        // platforma z?plad?g?nda an?masyon s?f?rlan?yor
        if (collision.gameObject.CompareTag("Platform"))
        {
            player.transform.parent = null;
        }

    }
    

}


