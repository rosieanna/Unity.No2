using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.3f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Ground"))  
        {
            Invoke("reloadScene", reloadDelay);
        } 
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
