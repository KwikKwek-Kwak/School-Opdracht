using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform Player;
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;

        print (123);
    }


}
