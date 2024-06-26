using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerLook : MonoBehaviour{
    public float sensX;
    public float sensY;
    public Transform orientation;
    public float xRotation;
    public float yRotation;

    private void Start(){
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = false;
    }

    private void Update(){
        // Get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X")*Time.deltaTime*sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")*Time.deltaTime*sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotate cam & player
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}


