using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMoveVoor : MonoBehaviour
{
    public float speed;
    public bool start;
    public Vector3 move;


    public void FixedUpdate()
    {
        if (start == true)
        {
            transform.position += transform.forward * speed;
        }
    }
}
