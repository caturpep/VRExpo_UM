using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotationTouchpad : MonoBehaviour
{

    public Transform Rotatable;
    public float RotationSpeed = 1;

    bool ismouseheld;
    Vector2 currentMousePosition;
    Vector2 mouseDeltaPosition;
    Vector2 lastMousePosition;
    bool istouchpadactive;

    private void Start()
    {

        ResetMousePosition();
        
    }

    public void ResetMousePosition() {
        currentMousePosition = Input.mousePosition;
        lastMousePosition = currentMousePosition;
        mouseDeltaPosition = currentMousePosition - lastMousePosition;
    } 

    void Update()
    {

        if (istouchpadactive) {

            currentMousePosition = Input.mousePosition;
            mouseDeltaPosition = currentMousePosition - lastMousePosition;

            Rotatable.transform.Rotate(0f, mouseDeltaPosition.x * RotationSpeed, 0f);

            lastMousePosition = currentMousePosition;
        }

    }

    public void ActivateTouchpad()
    {
        istouchpadactive = true;
        ResetMousePosition();
    }

    public void DeactivateTouchpad()
    {
        istouchpadactive = false;
    }
}
