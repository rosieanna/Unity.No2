using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float torqueAmount = 6;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) 
        {
            rb2d.AddTorque(torqueAmount);
        } 
        else if(Input.GetKey(KeyCode.D)) 
        {
            rb2d.AddTorque(-torqueAmount);
        } 
    }

}