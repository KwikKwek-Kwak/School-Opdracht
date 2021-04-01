using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public float afstandRec;
    public RaycastHit hit;
    public GameObject buttonImageGo;
    public Door door;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, afstandRec))
        {
            if(hit.transform.tag == "Button")
            {
                buttonImageGo.SetActive(true);
                if (Input.GetButtonDown("Fire1"))
                {
                    print("door open");
                    door.open = true;
                }
            }
            else
            {
                buttonImageGo.SetActive(false);
            }
        }
        else
        {
            buttonImageGo.SetActive(false);
        }
    }
}
