using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class MoneyHolder : MonoBehaviour
{
    public Transform[] moneyHolderTransforms;
    public List<GameObject> moneyCollector;
    public CustomerCollector customerCollector;
    public PlayerMoneyCollector playerMoneyCollector;
    GameManager gm;

    public float giveMoneyTime = 0.1f;
    public int numOfItemsHolding = 0;
    public bool playerIn;
    public int FloorItemHolding = 0;
    int floor = 0;
    Vector3 offset;
    Vector3 verticalOffset;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        StartCoroutine(RemoveMoneys());
    }
    // public void MakeMoney()
    // {
    //     if (customerCollector.customerCarCollector.car_AI.leaving)
    //     {
    //         gm.money +=150;
    //     }
    // }


    public void AddNewItem(Transform _itemToAdd)
    {
        if (FloorItemHolding > 7)
        {
            floor++;
            offset += new Vector3(0, .25f, 0);
            verticalOffset += new Vector3(0, .25f, 0);
            FloorItemHolding = 0;
        }
        _itemToAdd.SetParent(moneyHolderTransforms[FloorItemHolding], true);
        _itemToAdd.position = moneyHolderTransforms[FloorItemHolding].position + offset;
        _itemToAdd.localRotation = Quaternion.identity;
        moneyCollector.Add(_itemToAdd.gameObject);
        // numOfItemsHolding++;
        FloorItemHolding++;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIn = true;
            playerMoneyCollector = other.gameObject.GetComponent<PlayerMoneyCollector>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIn = false;
        }
    }

    IEnumerator RemoveMoneys()
    {
        while (true)
        {
            yield return new WaitForSeconds(giveMoneyTime);
            if (numOfItemsHolding > 0)
            {
                if (playerIn && numOfItemsHolding > 0)
                {
                    playerMoneyCollector.CollectMoney(moneyCollector[moneyCollector.Count - 1].transform);
                    moneyCollector.Remove(moneyCollector[moneyCollector.Count - 1]);
                    numOfItemsHolding--;
                    if (FloorItemHolding <= 0)
                    {
                        offset -= new Vector3(0, .25f, 0);
                        verticalOffset -= new Vector3(0, .25f, 0);
                        FloorItemHolding = 8;
                        floor--;
                    }
                    FloorItemHolding--;
                    MinOffset();
                }
                else
                {
                    yield return null;
                }
            }

        }
    }

    void MinOffset()
    {
        if (offset.y < 0 || verticalOffset.y < 0)
        {
            offset = new Vector3(0, 0, 0);
            verticalOffset = new Vector3(0, 0, 0);
        }
    }
}
