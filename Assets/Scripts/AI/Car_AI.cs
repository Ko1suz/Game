using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_AI : MonoBehaviour
{
    private Animator animator;
    public float speed;
    public bool isOpen = false;
    public bool leaving = false;
    CustomerCarCollector customerCarCollector;
    public CustomerCollector customerCollector;
    public MoneyHolder moneyHolder;
    public Transform parkPoint;
    public GameObject moneyPrefab;
    private void Start()
    {
        // customerCollector = GameObject.FindGameObjectWithTag("CustomerPoint").GetComponentInChildren<CustomerCollector>();
        // moneyHolder = GameObject.FindGameObjectWithTag("CustomerPoint").GetComponentInChildren<MoneyHolder>();
        customerCarCollector = GetComponent<CustomerCarCollector>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Parking();
        ParkingState();
        if (leaving)
        {
            transform.position += Vector3.forward * -speed / 10;
        }
    }

    void Parking()
    {
        if (!customerCollector.CustomerIsIn && !customerCarCollector.itemHoldFull)
        {
            Debug.Log("Hareket edıyormuyum");
            transform.position += Vector3.forward * speed / 10;
        }
        else
        {
            // var a = Quaternion.Euler(0, leftDoorOffset, 0);
            // var b = Quaternion.Euler(0, -rightDoorOffset, 0);
            // doorLeft.transform.rotation = Quaternion.Lerp(doorLeft.transform.rotation, a, doorOpenSpeed * Time.deltaTime);
            // doorRight.transform.rotation = Quaternion.Lerp(doorRight.transform.rotation, b, doorOpenSpeed * Time.deltaTime);
            animator.SetBool("KapıAnahtar", true);
            return;
        }
    }

    void ParkingState()
    {
        if (this.transform.position.z < parkPoint.transform.position.z && !leaving)
        {
            transform.position += Vector3.forward * speed / 10;
        }
        else
        {
            animator.SetBool("KapıAnahtar", true);
            return;
        }
    }

    void Leaving()
    {
        leaving = true;
        Paying();
    }
    int kartonKutuSayısı;
    int tahtaKutuSayısı;
    int toplamUretilenPara;
    void Paying()
    {
        for (int i = 0; i < customerCarCollector.numOfItemsHolding; i++)
        {
            if (customerCarCollector.boxs[i].GetComponent<ItemControl>().type == "KartonKutu")
            {
                kartonKutuSayısı++;
            }
            else if (customerCarCollector.boxs[i].GetComponent<ItemControl>().type == "TahtaKutu")
            {
                tahtaKutuSayısı++;
            }
        }
        toplamUretilenPara = (tahtaKutuSayısı*2)+kartonKutuSayısı;
        for (int i = 0; i < toplamUretilenPara; i++)
        {
            GameObject money = Instantiate(moneyPrefab, transform.position, moneyPrefab.transform.rotation);
            moneyHolder.AddNewItem(money.transform);
            moneyHolder.numOfItemsHolding++;
            Debug.LogWarning("ODeme sistemi");
        }
        kartonKutuSayısı = 0;
        tahtaKutuSayısı = 0;
    }


    void IsDoorOpen()
    {
        isOpen = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palet"))
        {
            customerCollector = other.gameObject.GetComponent<CustomerCollector>();
            moneyHolder = other.gameObject.GetComponentInChildren<MoneyHolder>();
        }
    }
}
