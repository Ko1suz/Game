using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ShiPrefab;
    public float spawnDelay = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
        GameObject Clone = Instantiate(ShiPrefab, transform.position+ new Vector3(0,3f,0), ShiPrefab.transform.rotation);
        Clone.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            GameObject Clone = Instantiate(ShiPrefab, transform.position + new Vector3(0,3f,0), ShiPrefab.transform.rotation);
            Clone.SetActive(true);
        }
    }
}
