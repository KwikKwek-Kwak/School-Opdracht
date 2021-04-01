using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    public Gate gate;
    public GameObject textGame3;

    public void keyCard()
    {
        Destroy(gameObject);
        gate.magDat = true;
    }
}
