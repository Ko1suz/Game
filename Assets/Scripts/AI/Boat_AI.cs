using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_AI : MonoBehaviour
{
    public float speed = 0.05f;

    CustomerCarCollector customerCarCollector;
    public CustomerCollector customerCollector;
    public MoneyHolder moneyHolder;
    public Transform parkPoint;
    public GameObject moneyPrefab;
    public bool leaving = false;
    UpgradeStats upgradeStats;


    private void Start()
    {
        customerCarCollector = GetComponent<CustomerCarCollector>();
    }

    private void Update()
    {
        
    }

    void ParkingState()
    {
        if (this.transform.position.z < parkPoint.transform.position.z && !leaving)
        {
            transform.position -= Vector3.forward * upgradeStats.MusteriAracizi / 10;
        }

        if (leaving)
        {
            
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palet"))
        {
            customerCollector = other.gameObject.GetComponent<CustomerCollector>();
            moneyHolder = other.gameObject.GetComponentInChildren<MoneyHolder>();
        }
    }
}
