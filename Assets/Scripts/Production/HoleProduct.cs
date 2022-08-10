using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleProduct : MonoBehaviour
{   
    public HoleCollector holeCollector;
    public GameObject product;
    public Transform productSpawnPoint;
    public FarAwayCollector Palet;
    public int productValue = 0;
    public float productionDelay = 2;
    private void Start() {
        StartCoroutine(CreateProduct());
    }
    IEnumerator CreateProduct()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(productionDelay);
            if (productValue<=0)
            {
                yield return null;
            }
            else
            {
                GameObject newproduct = Instantiate(product, productSpawnPoint.position, productSpawnPoint.rotation);
                newproduct.GetComponent<ItemControl>().speed = 0;
                newproduct.GetComponent<ItemControl>().Z_eksini_hareket_hizi = 0;
                newproduct.GetComponent<ItemControl>().Y_ekseni_hareket_yonu = true;
                newproduct.GetComponent<ItemControl>().Y_ekseni_hareket_hizi = 0.02f;
                productValue--;
            }
        }
    }

    void IncareseProductValue()
    {

    }
}
