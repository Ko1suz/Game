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
        if (transform.position.y < -9.5f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
