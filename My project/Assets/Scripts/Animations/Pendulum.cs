using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    Rigidbody2D rgb2d;
    public float moveSpeed;
    public float leftAngle;
    public float rightAngle;

    bool movingClockwise;

    private void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        movingClockwise = true;
    }

    private void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > rightAngle)
        {
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            movingClockwise = true;
        }
    }

    public void Move()
    {
        ChangeMoveDir();
        if (movingClockwise)
        {
            rgb2d.angularVelocity = moveSpeed;
        }
        if (!movingClockwise)
        {
            rgb2d.angularVelocity = -1 * moveSpeed;
        }
    }

}
