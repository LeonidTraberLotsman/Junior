using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBody : MonoBehaviour
{
    Rigidbody body;
    bool Active = true;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            if (Input.GetKey(KeyCode.W))
            {
                body.AddForce(transform.forward * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                body.AddForce(-transform.forward * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                body.AddForce(transform.right * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                body.AddForce(-transform.right * speed);
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                body.AddForce(-transform.up *100* speed);
            }
        }
    }
}
