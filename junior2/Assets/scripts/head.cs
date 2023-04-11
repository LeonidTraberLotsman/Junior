using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{

    public Transform playerBody;
    public float mouseSensivity = 100;
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y")* mouseSensivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40.0f, 40.0f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX); 
    }
}
