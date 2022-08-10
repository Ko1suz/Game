using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HoleCollector : MonoBehaviour
{
    public HoleProduct holeProduct;
    public Vector3 JumpPos = new Vector3(0.144999996f, 0.632000029f, -0.998000026f);
    public void Jump(Transform _itemToAdd)
    {

        _itemToAdd.DOJump(transform.position + JumpPos, 1f, 1, .5f).OnComplete(
           () =>
           {
               holeProduct.productValue++;
               _itemToAdd.gameObject.GetComponent<ItemControl>().Y_ekseni_hareket_hizi = 0.02f;
               _itemToAdd.gameObject.GetComponent<ItemControl>().Z_eksini_hareket_hizi = 0;
               _itemToAdd.gameObject.GetComponent<ItemControl>().speed = 0;
               Destroy(_itemToAdd.gameObject, 1.5f);
           }

       );
    }
}
