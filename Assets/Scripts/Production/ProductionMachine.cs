using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionMachine : MonoBehaviour
{
    public GameObject product;
    public Transform productSpawnPoint;

    public Collector Palet;
    public int productValue = 0;

    public bool stopSpawning = false;
    public float productionDelay = 2;
    public bool boxSpawned = false;
    // public float spawnTime;
    // public float spawnDelay;


    private void Start()
    {
        // InvokeRepeating("CreateProduct",spawnTime,spawnDelay);
        StartCoroutine(CreateProduct());

    }
    // IEnumerator ProductionTimer()
    // {
    //     yield return new WaitForSeconds(1f);
    //     CreateProduct();
    //     StopAllCoroutines();
    //     StartCoroutine(ProductionTimer());
    // }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }


    // void StopProduct()
    // {
    //     if (Palet.StopProduction)
    //     {
    //         CancelInvoke("CreateProduct");
    //     }
    // }

    // void CreateProduct()
    // {
    //     Instantiate(product, productSpawnPoint.position, productSpawnPoint.rotation);
    //     if (stopSpawning)
    //     {
    //         CancelInvoke("CreateProduct");
    //     }
    // }

    IEnumerator CreateProduct()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(productionDelay);
            if (Palet.StopProduction)
            {
                yield return null;
            }
            else
            {
                Instantiate(product, productSpawnPoint.position, productSpawnPoint.rotation);
                productValue++;
            }   
        }
    }
}
