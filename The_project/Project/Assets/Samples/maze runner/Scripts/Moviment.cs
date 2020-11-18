using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public float speed = 5;


    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rig.velocity = new Vector3(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rig.velocity = new Vector3(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector3(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector3(speed, 0f, 0f);
        }

        

    }
}
