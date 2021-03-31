using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWarp : MonoBehaviour
{
    private int nextSceneToLoad;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "lamboooooooo")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


}