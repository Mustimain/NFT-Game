using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeAnimation : MonoBehaviour
{
    public float velocity = 200f;

    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z - Time.deltaTime * velocity);
    }
}
