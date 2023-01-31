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

    // Update is called once per frame
    void Update()
    {
        Debug.Log("A");
    }
}
