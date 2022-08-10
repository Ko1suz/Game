using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class PlayerCollector : MonoBehaviour
{
    [Header("Ref")]
    public Transform boxHolderTransform;
    public List<GameObject> boxs = new List<GameObject>();

    public int numOfItemsHolding = 0;
    public float giveBoxTime = .1f;
    public bool warningLightOpen = false;
    public Vector3 offset;
    public Vector3 verticalOffset;
    public CustomerCollector collector;
    PlayerStats playerStats;



    private void Start()
    {
        playerStats = PlayerStats.instance;
        StartCoroutine(RemoveBoxes());
    }

    public void AddNewItem(Transform _itemToAdd)
    {
        _itemToAdd.DOJump(boxHolderTransform.position + verticalOffset, 1f, 1, .3f).OnComplete(
            () =>
            {
                _itemToAdd.SetParent(boxHolderTransform, true);
                _itemToAdd.localRotation = Quaternion.identity;
                _itemToAdd.position = boxHolderTransform.position + offset;

                // numOfItemsHolding++;
                boxs.Add(_itemToAdd.gameObject);
                offset += new Vector3(0, .6f, 0);
                verticalOffset += new Vector3(0, .6f, 0);
                // _itemToAdd.GetComponent<ItemControl>().
            }

        );
    }

    private void Update()
    {
        warningLightControl();
        // offset = new Vector3(0, .6f * numOfItemsHolding, 0);
    }

    void warningLightControl()
    {
        if (numOfItemsHolding > 0)
        {
            warningLightOpen = true;
        }
        else
        {
            warningLightOpen = false;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Palet"))
        {
            collector = other.gameObject.GetComponent<CustomerCollector>();
        }
    }


    IEnumerator RemoveBoxes()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(playerStats.urunToplamaVeVermeHizi);
            CustomerCollector _collector = collector;
            if (_collector.PlayerIsIn && !_collector.itemHoldFull)
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
                        _collector.numOfItemsHolding++;
                        _collector.AddNewItem(boxs.Last().transform);
                        boxs.Remove(boxs.Last());
                        numOfItemsHolding--;
                        offset -= new Vector3(0, .6f, 0);
                        verticalOffset -= new Vector3(0, .6f, 0);
                    }
                }
            }
            else if (!_collector.PlayerIsIn)
            {
                yield return null;
            }
            Debug.Log("Çalışıyorum");
        }
    }
}
