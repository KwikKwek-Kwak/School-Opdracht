using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public float afstandRec;
    public RaycastHit hit;
    public GameObject buttonImageGo;
    public GameObject text;
    
    public KeyCard keyCard;
    public Text textKeyCardFound;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, afstandRec))
        {
            if (hit.transform.tag == "Key")
            {
                buttonImageGo.SetActive(true);
                text.SetActive(true);
                if (Input.GetButtonDown("Fire1"))
                {
                    keyCard.keyCard();
                    textKeyCardFound.keyFound = true;
                    textKeyCardFound.timeLeft = 0;
                }
            }
            else
            {
                buttonImageGo.SetActive(false);
                text.SetActive(false);
            }
        }
        else
        {
            text.SetActive(false);
            buttonImageGo.SetActive(false);
        }
    }
}
