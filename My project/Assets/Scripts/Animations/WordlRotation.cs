using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordlRotation : MonoBehaviour
{
    public float velocity= 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(rot.x,rot.y,rot.z +Time.deltaTime * velocity);
    }
}
