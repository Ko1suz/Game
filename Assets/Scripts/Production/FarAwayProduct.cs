using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarAwayProduct : MonoBehaviour
{
    public string Tier = "1";
    public GameObject product;
    public Transform productSpawnPoint;
    public FarAwayCollector UzakPalet;
    public float productionDelay = 2;
    public int productValue = 0;
    public bool run = false;
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
            if (run)
            {
                if (Tier == "1")
                {
                    yield return new WaitForSecondsRealtime(upgradeStats.TierBirYanUretimBandıDelayi);
                }
                else if (Tier == "2")
                {
                    yield return new WaitForSecondsRealtime(upgradeStats.TierBirYanUretimBandıDelayi);
                }
                else if (Tier == "3")
                {
                    yield return new WaitForSecondsRealtime(upgradeStats.TierUcYanUretimBandıDelayi);
                }
                else if (Tier == "4")
                {
                    yield return new WaitForSecondsRealtime(upgradeStats.TierDortYanUretimBandıDelayi);
                }
                else
                {
                    yield return null;
                }
                
                if (UzakPalet.StopProduction)
                {
                    yield return null;
                }
                else
                {
                    GameObject productedBox = Instantiate(product, productSpawnPoint.position, productSpawnPoint.rotation);
                    productedBox.GetComponent<ItemControl>().turnWay = true;
                    productValue++;
                }
            }
            else
            {
                yield return null;
            }
        }
    }
}
