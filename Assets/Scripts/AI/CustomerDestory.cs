using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDestory : MonoBehaviour
{   
    private CustomerSpawner customerSpawner;

    private void Start() {
        customerSpawner = GetComponent<CustomerSpawner>();
    }
    public bool icerde = false;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag =="Customer")
        {
            icerde = true;
            customerSpawner.Customers.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
