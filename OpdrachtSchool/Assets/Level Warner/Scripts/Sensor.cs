using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public DeadMoveVoor deadMoveVoor;
    public DeadMoveUp deadMoveUp;


    public void OnTriggerEnter(Collider other)
    {
        deadMoveVoor.start = true;
        deadMoveUp.start = true;
    }

}
