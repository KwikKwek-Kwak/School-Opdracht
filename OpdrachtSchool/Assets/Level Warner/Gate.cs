using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject player;
    public GameObject securty;
    public GameObject granted;
    public GameObject deneid;
    public GameObject force;

    public AudioSource grantedSound;
    public AudioSource deneidSound;

    public bool magDat;

    public float timeGatePlus;
    float timeGate;


    void Update()
    {
        if (timeGate > 0)
        {
            timeGate -= Time.deltaTime;
        }

        if (timeGate < 0)
        {
            gateReset();
        }

        if(magDat == false)
        {
            force.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(magDat == true)
            {
                force.SetActive(false);

                securty.SetActive(false);
                granted.SetActive(true);

                grantedSound.Play();
            }
            else
            {
                securty.SetActive(false);
                deneid.SetActive(true);

                deneidSound.Play();
            }

            timeGate = timeGatePlus;
        }
    }

    public void gateReset()
    {
        securty.SetActive(true);
        granted.SetActive(false);
        deneid.SetActive(false);
    }
}
