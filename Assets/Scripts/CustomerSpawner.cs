using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public int CustomerDelay;
    public List<GameObject> Customers;
    public Transform _customerSpawnPoint;
    private GameObject customer;
    public GameObject _customer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateCustomer());
    }

    IEnumerator CreateCustomer()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(CustomerDelay);
            if (Customers.Count>=1)
            {
                yield return null;
            }
            else
            {
                customer = Instantiate(_customer, _customerSpawnPoint.position, _customerSpawnPoint.rotation);
                customer.SetActive(true);
                Customers.Add(customer);
            }   
        }
    }
}
