using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookSpawner : MonoBehaviour
{
    public GameObject hookAndRope;
    public Transform spawnPoint;
    public float spawnTime = 3f;
    UpgradeStats upgradeStats;


    private void Start()
    {
        upgradeStats = UpgradeStats.instance;
        StartCoroutine(StartDelay());
    }


    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(3f);
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(upgradeStats.KancaDelay);
            Instantiate(hookAndRope,spawnPoint.position,spawnPoint.rotation);
        }
    }
}
