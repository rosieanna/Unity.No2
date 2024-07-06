using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") 
        {
            Invoke("reloadScene", reloadDelay);
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
