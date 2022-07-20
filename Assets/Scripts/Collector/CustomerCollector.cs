using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class CustomerCollector : MonoBehaviour
{


    [Header("Ref")]
    public Transform[] boxHolderTransform;

    public List<GameObject> boxs = new List<GameObject>();
    public bool PlayerIsIn = false;
    public bool CustomerIsIn = false;
    public CustomerCarCollector customerCarCollector;
    int FloorItemHolding = 0;
    int floor = 1;
    public int numOfItemsHolding = 0;
    public int maxItemHold;
    public bool itemHoldFull = false;
    public Vector3 offset;
    public Vector3 verticalOffset;

    private void Start()
    {
        StartCoroutine(RemoveBoxes());
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
                // _itemToAdd.localScale = new Vector3(0.723531485f, 0.400000006f, 0.33744821f);
                itemTypeControl(_itemToAdd.GetComponent<ItemControl>());
                _itemToAdd.position = boxHolderTransform[FloorItemHolding].position + offset;
                _itemToAdd.localRotation = Quaternion.identity;
                boxs.Add(_itemToAdd.gameObject);
                // numOfItemsHolding++;
                FloorItemHolding++;

            }

        );
    }

    void itemTypeControl(ItemControl _itemType)
    {
        if (_itemType.type == "KartonKutu")
        {
            _itemType.transform.localScale = new Vector3(0.723531485f, 0.400000006f, 0.33744821f);
        }
        else if (_itemType.type == "TahtaKutu")
        {
            _itemType.transform.localScale = new Vector3(0.836411119f,0.333999991f,0.273574203f);
        }
    }

    private void Update()
    {
        if (numOfItemsHolding >= maxItemHold)
        {
            itemHoldFull = true;
        }
        else
        {
            itemHoldFull = false;
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerIsIn = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Customer"))
        {
            CustomerIsIn = true;
            customerCarCollector = other.gameObject.GetComponent<CustomerCarCollector>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerIsIn = false;
        }
        if (other.gameObject.CompareTag("Customer"))
        {
            CustomerIsIn = false;
        }
    }

    IEnumerator RemoveBoxes()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(.6f);
            CustomerCarCollector _collector = customerCarCollector;
            if (CustomerIsIn && !_collector.itemHoldFull && _collector.GetComponent<Car_AI>().isOpen)
            {
                if (numOfItemsHolding == 0)
                {
                    yield return null;
                }
                else
                {
                    if (_collector.itemHoldFull)
                    {
                        yield return null;
                    }
                    else
                    {
                        if (boxs.Count <= 0)
                        {
                            Debug.LogWarning("Son item = null");
                            yield return null;
                        }
                        else
                        {
                            // Debug.Log("son item" + (boxs.Count - 1));
                            // Debug.Log("item ismi" + boxs[boxs.Count - 1].name);
                            _collector.numOfItemsHolding++;
                            _collector.AddNewItem(boxs[boxs.Count - 1].transform);
                            boxs.Remove(boxs[boxs.Count - 1]);
                            numOfItemsHolding--;
                            if (FloorItemHolding == 0)
                            {
                                FloorItemHolding = 10;
                                offset -= new Vector3(0, .6f, 0);
                                verticalOffset -= new Vector3(0, .6f, 0);
                                floor--;
                            }
                            FloorItemHolding--;
                        }

                    }
                }
            }
            else if (!CustomerIsIn)
            {
                yield return null;
            }
            Debug.Log("Çalışıyorum");
        }
    }

}
