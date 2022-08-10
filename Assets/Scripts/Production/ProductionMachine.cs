using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionMachine : MonoBehaviour
{
    public string Tier = "1";
    public GameObject product;
    public Transform productSpawnPoint;
    public Collector Palet;
    public int productValue = 0;
    public float productionDelay = 2;
    UpgradeStats upgradeStats;
    
    private void Start()
    {
        upgradeStats = UpgradeStats.instance;
        StartCoroutine(CreateProduct());
    }
    IEnumerator CreateProduct()
    {
        while (true)
        {
            if (Tier=="1")
            {
                yield return new WaitForSecondsRealtime(upgradeStats.TierBirUretimBandiDelayi);
            }
            else if (Tier=="2")
            {
                yield return new WaitForSecondsRealtime(upgradeStats.TierIkiUretimBandiDelayi);
            }
            else if (Tier=="3")
            {
                yield return new WaitForSecondsRealtime(upgradeStats.TierUcUretimBandiDelayi);
            }
            else if (Tier=="4")
            {
                yield return new WaitForSecondsRealtime(upgradeStats.TierDortUretimBandiDelayi);
            }
            else
            {
                yield return null;
            }
            
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
