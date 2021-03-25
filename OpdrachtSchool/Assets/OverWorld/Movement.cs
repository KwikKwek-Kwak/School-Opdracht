using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Vector3 move;
    public float moveSpeed;
    public float h;
    public float v;


    void Start()
    {
        moveSpeed = 10;
    }


    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        move.x = h;
        move.z = v;

        if (Input.GetButtonDown("sprint"))
        {
            moveSpeed = 20;
        }

        if (Input.GetButtonUp("sprint"))
        {
            moveSpeed = 10;
        }

        GetComponent<Transform>().Translate(move * Time.deltaTime * moveSpeed);
    }
}
