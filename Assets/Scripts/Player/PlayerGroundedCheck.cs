using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedCheck : MonoBehaviour
{


    private void Update()
    {
        Check();
    }

    void Check()
    {
        if (transform.position.y < -0.05f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
