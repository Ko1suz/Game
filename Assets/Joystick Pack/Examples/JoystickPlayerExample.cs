using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float rotationAngle;
    public static bool warningLight;
    float angle;
    public DynamicJoystick variableJoystick;
    public Rigidbody rb;


    private void Update()
    {

    }
    public void FixedUpdate()
    {
        // Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        // // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        // rb.velocity = direction * speed * Time.fixedDeltaTime*100;

        if (Input.GetMouseButton(0))
        {
            JoystickMovment();
            warningLight = true;
        }
        else
        {
            warningLight = false;
        }
    }

    void JoystickMovment()
    {
        float horizontal = variableJoystick.Horizontal;
        float vertical = variableJoystick.Vertical;
        Vector3 addedPos = new Vector3(horizontal * -speed * Time.deltaTime, 0, vertical * -speed * Time.deltaTime);
        transform.position += addedPos;
        Vector3 direction = Vector3.right * vertical + -Vector3.forward * horizontal;

        angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle +90 + rotationAngle, new Vector3(0,1,0));
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.deltaTime);
    }
}