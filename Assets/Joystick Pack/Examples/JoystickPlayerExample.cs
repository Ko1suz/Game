using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    
    public float rotationAngle;
    public static bool warningLight;
    float angle;
    public DynamicJoystick variableJoystick;
    public Rigidbody rb;
    PlayerStats playerStats;

    private void Start()
    {
        playerStats = PlayerStats.instance;
    }
    public void FixedUpdate()
    {
        // Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        // // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        // rb.velocity = direction * speed * Time.fixedDeltaTime*100;

        transform.position = new Vector3(transform.position.x,0.02f,transform.position.z);

        if (Input.GetMouseButton(0))
        {
            JoystickMovment();
            warningLight = true;
        }
        else
        {
            warningLight = false;
            rb.velocity = Vector3.zero;
        }
    }

    void JoystickMovment()
    {
        float horizontal = variableJoystick.Horizontal;
        float vertical = variableJoystick.Vertical;
        Vector3 addedPos = new Vector3(horizontal * -playerStats.araçHizi * Time.deltaTime, 0, vertical * -playerStats.araçHizi * Time.deltaTime);
        rb.velocity +=  addedPos;
        Vector3 direction = Vector3.right * vertical + -Vector3.forward * horizontal;

        angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle + 90 + rotationAngle, new Vector3(0, 1, 0));
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.deltaTime);
    }
}