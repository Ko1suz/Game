using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class CustomerCarCollector : MonoBehaviour
{

    [Header("Ref")]
    public Transform[] boxHolderTransform;

    public List<GameObject> boxs = new List<GameObject>();
    private Animator animator;
    public Car_AI car_AI;
    int FloorItemHolding = 0;
    int floor = 1;
    [HideInInspector] public int numOfItemsHolding = 0;
    public int maxItemHold = 6;
    [HideInInspector] public bool itemHoldFull = false;
    public Vector3 offset;
    public Vector3 verticalOffset;


    private void Start() {
        animator = GetComponent<Animator>();
        car_AI = GetComponent<Car_AI>();
    }
    public void AddNewItem(Transform _itemToAdd)
    {
        Debug.Log("Araç palet tarafi çalışıyor");
        if (FloorItemHolding > 1)
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
                // numOfItemsHolding++;
                FloorItemHolding++;
            }

        );
    }

    private void Update()
    {
        if (numOfItemsHolding >= maxItemHold)
        {
            itemHoldFull = true;
            animator.SetBool("KapıKapalıAnahtar",true);
        }
        else
        {
            itemHoldFull = false;
        }
    }
}
