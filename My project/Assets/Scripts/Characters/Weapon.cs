using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletFrefab;
    Animator animator;
    public Animator animator1;


    private void Start()
    {
     animator = GetComponent<Animator>();   
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();
            
        } 
    }

    public void Shoot()
    {

        Instantiate(bulletFrefab, firePoint.position, firePoint.rotation);

        if (animator.GetFloat("Speed") == 0 ) {

            animator.SetTrigger("attack");

        }

        animator1.SetTrigger("shoot1");

    }
}
