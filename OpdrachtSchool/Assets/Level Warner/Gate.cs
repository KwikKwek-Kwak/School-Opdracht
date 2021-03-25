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

    public float backFire;

    public float timeGatePlus;
    float timeGate;
    public Movement movement;


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
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(magDat == true)
            {
                securty.SetActive(false);
                granted.SetActive(true);

                grantedSound.Play();
            }
            else
            {
                player.gameObject.GetComponent<Rigidbody>().AddForce(securty.transform.forward * backFire);
                securty.SetActive(false);
                deneid.SetActive(true);

                movement.moveSpeed = 0;
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
        movement.moveSpeed = 10;
    }
}
