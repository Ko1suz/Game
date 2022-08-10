using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HookCollector : MonoBehaviour
{
    public Transform boxHolderTransform;
    public int numOfItemsHolding = 0;
    public int maxItemHolding = 1;
    public float giveBoxTime = .1f;
    public bool hookIn = false;
    Collector uretimPaleti;
    CustomerCollector customerPalet;
    Transform holdedBox;
    public void AddNewItem(Transform _itemToAdd)
    {
        _itemToAdd.DOJump(boxHolderTransform.position, 1f, 1, .25f).OnComplete(
            () =>
            {
                _itemToAdd.SetParent(this.gameObject.transform, true);
                _itemToAdd.localPosition = new Vector3(0.00299835205f, -6.28899956f, 0.0403518677f);
                holdedBox = _itemToAdd;
            }
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UretimPaleti"))
        {
            uretimPaleti = other.gameObject.GetComponent<Collector>();
            hookIn = true;
            uretimPaleti.HookCollect(this);
        }
        else if (other.gameObject.CompareTag("Palet"))
        {
            customerPalet = other.gameObject.GetComponent<CustomerCollector>();
            RemoveBox();
        }
    }
    void RemoveBox()
    {
        if (numOfItemsHolding>0 && !customerPalet.itemHoldFull)
        {
            customerPalet.AddNewItem(holdedBox);
            customerPalet.numOfItemsHolding++;
            holdedBox = null;
            numOfItemsHolding--;
        }
        else
        {
            return;
        }
    }



}
