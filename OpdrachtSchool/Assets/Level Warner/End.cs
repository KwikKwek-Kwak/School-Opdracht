using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public Image img;
    public GameObject image;
   
    public bool startEnd;
    public float warp;
    public float timer;
   
    public Movement movement;

    public void Start()
    {
        image.SetActive(true);
        movement.runSpeed = 10;
        img.canvasRenderer.SetAlpha(1.0f);
        FadeOut();
    }

    public void Update()
    {
        if(startEnd == true)
        {
            if(timer > warp)
            {
                SceneManager.LoadScene(1);
                movement.runSpeed = 20;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FadeIn();
        }
    }

    public void FadeIn()
    {
        img.CrossFadeAlpha(1, 1, false);
        startEnd = true;
    }

    public void FadeOut()
    {
        img.CrossFadeAlpha(0, 1, false);
    }
}
