using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float mouseXSensitivity = 100f;
    public float mouseYSensitivity = 100f;

    public Transform character;
    private float cameraXRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * mouseXSensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * mouseYSensitivity * Time.deltaTime;
        cameraXRotation -= y;
        cameraXRotation = Mathf.Clamp(cameraXRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(cameraXRotation, 0, 0);

        character.Rotate(Vector3.up * x);
    }
}
