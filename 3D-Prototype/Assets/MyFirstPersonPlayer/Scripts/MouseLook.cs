﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        //Get mouse input and assign it to two floats
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Rotate player GameObject with horizontal mouse input
        player.transform.Rotate(Vector3.up * mouseX);

        //Rotate camera around the x axis with vertical mouse input
        verticalLookRotation -= mouseY;

        //Limit the vertical roitation with clamp
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        //apply rotation to our camera based on clamped output
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
