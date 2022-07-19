using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class Collector : MonoBehaviour
{
    [Header("Ref")]
    public Transform[] boxHolderTransform;

    public List<GameObject> boxs = new List<GameObject>();
    public ProductionMachine productionMachine;
    public bool exit = false;
    public bool playerIn = false;
    public float giveBoxTime = 0.1f;
    int FloorItemHolding = 0;
    int floor = 1;
    [HideInInspector] public int numOfItemsHolding = 0;
    public int maxItemHold;
    public bool StopProduction = false;
    public Vector3 offset;
    public Vector3 verticalOffset;
    PlayerCollector playerCollector;



    private void Start()
    {
        StartCoroutine(RemoveBoxess());
    }
    private void Update()
    {
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
                boxs.Add(_itemToAdd.gameObject);
                numOfItemsHolding++;
                FloorItemHolding++;
            }

        );


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            exit = false;
            playerIn = true;
            playerCollector = other.gameObject.GetComponent<PlayerCollector>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIn = false;

        }
    }
    IEnumerator RemoveBoxess()
    {
        while (true)
        {
            yield return new WaitForSeconds(giveBoxTime);
            // PlayerCollector _collector = collector;
            if (playerIn)
            {
                if (numOfItemsHolding > 0)
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


}
