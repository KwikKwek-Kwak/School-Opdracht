using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open;
    public GameObject door;

    public void Update()
    {
        if (open == true)
        {
            door.GetComponent<Animator>().Play("Deur|DeurAction_001");
            open = false;
        }
    }
}
