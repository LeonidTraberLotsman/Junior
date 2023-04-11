using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(0, 5, 0);

        Debug.Log("A");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            transform.position = transform.position + new Vector3(0, 0.01f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position = transform.position + new Vector3(0.01f,0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position = transform.position + new Vector3(-0.01f, 0, 0);
        }
    }

}
