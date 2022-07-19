using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UyariIsigi : MonoBehaviour
{
    public Light warningLight;
    public PlayerCollector playerCollector;
    
    private void FixedUpdate() {
        LightRotation();
    }

    public void LightRotation()
    {
        
        if (playerCollector.warningLightOpen)
        {
            transform.Rotate(0,5,0);
            warningLight.enabled = true;
        }
        else
        {
            warningLight.enabled = false;
        }
    }
}
