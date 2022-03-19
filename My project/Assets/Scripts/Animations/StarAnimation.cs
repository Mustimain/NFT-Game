using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    Vector3 vector11;
     float velocityX = 0.4f;
     float velocityY = 0.2f;


    // Update is called once per frame
    void Update()
    {

        vector11 = transform.position;
        vector11.x -= velocityX * Time.deltaTime;
        vector11.y += velocityY * Time.deltaTime;

        transform.position = vector11;
    }
}
