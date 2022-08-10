using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public Quaternion rotOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FallowSystem();
    }

    void FallowSystem()
    {
        transform.position = playerTransform.position +offset;
        // transform.rotation = rotOffset;
    }
}
