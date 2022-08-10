using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public bool isBoat = false;
    public int CustomerDelay;
    public List<GameObject> Customers;
    public Transform _customerSpawnPoint;
    private GameObject customer;
    public GameObject _customer;
    public GameObject _customerTier2;
    public GameObject _customerBoat;

    public static bool LevelUp = false;
    UpgradeStats upgradeStats;
    void Start()
    {
        upgradeStats = UpgradeStats.instance;
        StartCoroutine(CreateCustomer());
    }

    IEnumerator CreateCustomer()
    {
        while (true)
        {
            yield return new WaitForSeconds(upgradeStats.MusteriGelmeSuresi);

            for (var i = Customers.Count - 1; i > -1; i--)
            {
                if (Customers[i] == null)
                    Customers.RemoveAt(i);
            }

            if (Customers.Count >= 1)
            {
                yield return null;
            }
            else
            {
                if (isBoat)
                {
                    customer = Instantiate(_customerBoat, _customerSpawnPoint.position + new Vector3(0,3,0), _customerBoat.transform.rotation);
                }
                else if (LevelUp)
                {
                    customer = Instantiate(_customerTier2, _customerSpawnPoint.position, _customerTier2.transform.rotation);
                }
                else
                {
                    customer = Instantiate(_customer, _customerSpawnPoint.position, _customerSpawnPoint.rotation);
                }

                customer.SetActive(true);
                Customers.Add(customer);
            }
        }
    }
}
