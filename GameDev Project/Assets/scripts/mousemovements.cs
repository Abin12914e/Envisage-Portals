using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemovements : MonoBehaviour
{
    public float mousesensitivity = 100f;
    public Transform playerbody;
    float xrot = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;
        xrot -= mouseY;
        xrot = Mathf.Clamp(xrot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrot*10, mouseX, 0f);

        playerbody.Rotate(Vector3.up * mouseX*10);


    }
}
