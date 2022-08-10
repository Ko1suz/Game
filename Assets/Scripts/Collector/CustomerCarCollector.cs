using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class CustomerCarCollector : MonoBehaviour
{

    [Header("Ref")]
    public string type = "Van";
    public Transform[] boxHolderTransform;

    public List<GameObject> boxs = new List<GameObject>();
    private Animator animator;
    // public Car_AI car_AI;
    int FloorItemHolding = 0;
    int floor = 1;
    [HideInInspector] public int numOfItemsHolding = 0;
    public int maxItemHold = 6;
    public bool itemHoldFull = false;
    public Vector3 offset;
    public Vector3 verticalOffset;


    private void Start()
    {
        animator = GetComponent<Animator>();
        // car_AI = GetComponent<Car_AI>();
        if (type=="Truck")
        {
            maxItemHold = 16;
        }
    }
    public void AddNewItem(Transform _itemToAdd)
    {
        Debug.Log("Araç palet tarafi çalışıyor");
        if (FloorItemHolding > 1 && type == "Van")
        {
            floor++;
            offset += new Vector3(0, .6f, 0);
            verticalOffset += new Vector3(0, .6f, 0);
            FloorItemHolding = 0;
        }
        else if (FloorItemHolding > 3 && type == "Truck")
        {
            floor++;
            offset += new Vector3(0, .6f, 0);
            verticalOffset += new Vector3(0, .6f, 0);
            FloorItemHolding = 0;
        }
        else if (FloorItemHolding > 41 && type == "Boat")
        {
            floor++;
            offset += new Vector3(0, .6f, 0);
            verticalOffset += new Vector3(0, .6f, 0);
            FloorItemHolding = 0;
        }
        _itemToAdd.DOJump(boxHolderTransform[FloorItemHolding].position + verticalOffset, 1f, 1, .3f).OnComplete(
            () =>
            {
                if (type == "Boat")
                {
                   _itemToAdd.transform.localScale = new Vector3(1,1,1); 
                }
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
        Anims();
    }

    void Anims()
    {
        if (type == "Van")
        {
            if (numOfItemsHolding >= maxItemHold)
            {
                itemHoldFull = true;
                animator.SetBool("KapıKapalıAnahtar", true);
            }
            else
            {
                itemHoldFull = false;
            }
        }
        else if (type == "Truck")
        {
            if (numOfItemsHolding >= maxItemHold)
            {
                itemHoldFull = true;
                animator.SetBool("DoorClose", true);
            }
            else
            {
                itemHoldFull = false;
            }
        }
        else if (type == "Boat")
        {
            if (numOfItemsHolding >= maxItemHold)
            {
                itemHoldFull = true;
                animator.SetTrigger("DoorClose");
            }
            else
            {
                itemHoldFull = false;
            }
        }

    }
}
