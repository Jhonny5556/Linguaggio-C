using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    
   

    float RotazioneX = 0f;

    public Transform playerBody;
    // Starrais called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        RotazioneX -= mouseY;
        RotazioneX = Mathf.Clamp(RotazioneX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(RotazioneX, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
