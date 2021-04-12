using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public float timeLeft;
    public GameObject textGame;
    public GameObject textGame1;
    public GameObject textGame2;
    public GameObject textGame3;

    public bool intro;
    public bool cantLeave;
    public bool keyFound;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 0;
        intro = true;

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft += Time.deltaTime;

        if (intro == true)
        {
            if (timeLeft > 0)
            {
                textGame.SetActive(true);
            }
            if (timeLeft > 4)
            {
                textGame.SetActive(false);
                textGame1.SetActive(true);
            }
            if (timeLeft > 9)
            {
                textGame1.SetActive(false);
                intro = false;
            }
        }
        if (cantLeave == true)
        {
            textGame2.SetActive(true);
            textGame.SetActive(false);
            textGame1.SetActive(false);
            if (timeLeft > 3)
            {
                textGame2.SetActive(false);
                cantLeave = false;
            }
        }
        if (keyFound == true)
        {
            textGame3.SetActive(true);
            if (timeLeft > 5)
            {
                textGame3.SetActive(false);
                keyFound = false;
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gate")
        {
            cantLeave = true;
            timeLeft = 0;
        }
    }
}
