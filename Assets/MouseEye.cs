using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEye : MonoBehaviour
{

    public float xRotation;
    public float yRotation;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yRotation -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        yRotation = Mathf.Clamp(yRotation, -80, 80);
        xRotation += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        xRotation = xRotation % 360;
        transform.localEulerAngles = new Vector3(yRotation, xRotation, 0);
    }
}