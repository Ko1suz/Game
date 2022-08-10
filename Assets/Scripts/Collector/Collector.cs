using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class Collector : MonoBehaviour
{
    public string Tier = "1";
    [Header("Ref")]
    public Transform[] boxHolderTransform;
    // public Transform activetedTransform;
    public float activeDistence = 10;

    public List<GameObject> boxs = new List<GameObject>();
    public ProductionMachine productionMachine;
    public float giveBoxTime = 0.1f;
    int FloorItemHolding = 0;
    int floor = 1;
    [HideInInspector] public int numOfItemsHolding = 0;
    public int maxItemHold;
    public bool StopProduction = false;
    public Vector3 offset;
    public Vector3 verticalOffset;
    PlayerCollector playerCollector;
    GameManager gm;
    PlayerStats playerStats;
    UpgradeStats upgradeStats;

    private void Start()
    {
        upgradeStats = UpgradeStats.instance;
        playerStats = PlayerStats.instance;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        playerCollector = gm.PlayerTransform.gameObject.GetComponent<PlayerCollector>();
        StartCoroutine(RemoveBoxess());
    }
    private void Update()
    {
        if (Tier == "1")
        {
            maxItemHold = upgradeStats.TierBirUrunTutmaSayısı;
        }
        else if (Tier == "2")
        {
            maxItemHold = upgradeStats.TierIkiUrunTutmaSayısı;
        }
        
        if (productionMachine.productValue >= maxItemHold)
        {
            StopProduction = true;
        }
        else
        {
            StopProduction = false;
        }
    }


    public void AddNewItem(Transform _itemToAdd)
    {
        if (FloorItemHolding > 9)
        {
            floor++;
            offset += new Vector3(0, .6f, 0);
            verticalOffset += new Vector3(0, .6f, 0);
            FloorItemHolding = 0;
        }
        _itemToAdd.DOJump(boxHolderTransform[FloorItemHolding].position + verticalOffset, 1f, 1, .3f).OnComplete(
            () =>
            {
                _itemToAdd.SetParent(boxHolderTransform[FloorItemHolding], true);
                _itemToAdd.position = boxHolderTransform[FloorItemHolding].position + offset;
                _itemToAdd.localRotation = Quaternion.identity;
                if (_itemToAdd.GetComponent<ItemControl>().type == "KartonKutu")
                {
                    _itemToAdd.localScale = new Vector3(0.75f, 0.400000006f, 0.333333313f);
                }
                else if (_itemToAdd.GetComponent<ItemControl>().type == "TahtaKutu")
                {
                    _itemToAdd.localScale = new Vector3(0.836411119f, 0.333999991f, 0.273574203f);
                }
                _itemToAdd.GetComponent<ItemControl>().speed = 0;
                _itemToAdd.GetComponent<ItemControl>().Y_ekseni_hareket_hizi = 0;
                boxs.Add(_itemToAdd.gameObject);
                numOfItemsHolding++;
                FloorItemHolding++;
            }

        );
    }
    IEnumerator RemoveBoxess()
    {
        while (true)
        {
            yield return new WaitForSeconds(playerStats.urunToplamaVeVermeHizi);
            if (PlayerDistance() <= activeDistence)
            {
                if (numOfItemsHolding > 0 && playerCollector.numOfItemsHolding < playerStats.maxItemTutmaSayisi)
                {

                    numOfItemsHolding--;
                    playerCollector.AddNewItem(boxs.Last().transform);
                    playerCollector.numOfItemsHolding++;
                    boxs.Remove(boxs.Last());
                    if (FloorItemHolding == 0)
                    {
                        FloorItemHolding = 10;
                        offset -= new Vector3(0, .6f, 0);
                        verticalOffset -= new Vector3(0, .6f, 0);
                        floor--;
                    }
                    FloorItemHolding--;
                    productionMachine.productValue--;
                }
                else
                {
                    yield return null;
                }
            }
            else
            {
                yield return null;
            }

        }
    }

    public void HookCollect(HookCollector hookCollector)
    {
        if (hookCollector.hookIn)
        {
            if (numOfItemsHolding > 0 && hookCollector.numOfItemsHolding < hookCollector.maxItemHolding)
            {
                numOfItemsHolding--;
                hookCollector.AddNewItem(boxs.Last().transform);
                boxs.Remove(boxs.Last());
                hookCollector.numOfItemsHolding++;
                if (FloorItemHolding == 0)
                {
                    FloorItemHolding = 10;
                    offset -= new Vector3(0, .6f, 0);
                    verticalOffset -= new Vector3(0, .6f, 0);
                    floor--;
                }
                FloorItemHolding--;
                productionMachine.productValue--;
            }
        }
    }
    float PlayerDistance()
    {
        float targetDistance = Vector3.Distance(transform.position + new Vector3(0, -0.8f, 0), gm.PlayerTransform.position);
        return targetDistance;
    }


}
