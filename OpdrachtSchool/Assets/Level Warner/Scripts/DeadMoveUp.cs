using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMoveUp : MonoBehaviour
{
    public float speed;
    public float popup;
    public float times;
    public bool start;
    public Vector3 move;


    public void FixedUpdate()
    {
        if (start == true)
        {
            transform.position += transform.forward * speed;
            
            if (times == 0)
            {
                transform.position += transform.up * popup;
                times++;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
}
