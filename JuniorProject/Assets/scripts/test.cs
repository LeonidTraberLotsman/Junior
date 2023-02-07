using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3, 4, 5);
        
        Debug.Log("A");
    }

    public IEnumerator testCoroutine()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) transform.position = transform.position + new Vector3(0, 0.01f, 0);
        Debug.Log("A");

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * 0.1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * 0.1f;
        }
    }
}
