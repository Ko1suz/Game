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
    UpgradeStats upgradeStats;
    private void Start()
    {
        upgradeStats = UpgradeStats.instance;
        customerCarCollector = GetComponent<CustomerCarCollector>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Parking();
        ParkingState();
        if (leaving)
        {
            if (customerCarCollector.type == "Boat")
            {
                transform.position += Vector3.forward * upgradeStats.MusteriAracizi / 10;

            }
            else
            {
                transform.position += Vector3.forward * -upgradeStats.MusteriAracizi / 10;
            }

        }
    }



    void ParkingState()
    {
        if (customerCarCollector.type == "Boat")
        {
            if (this.transform.position.z > parkPoint.transform.position.z && !leaving)
            {
                transform.position += Vector3.forward * -upgradeStats.MusteriAracizi / 10;
            }
            else
            {
                animator.SetTrigger("DoorOpen");
            }
            return;
        }
        else
        {
            if (this.transform.position.z < parkPoint.transform.position.z && !leaving)
            {
                transform.position += Vector3.forward * upgradeStats.MusteriAracizi / 10;
            }
            else
            {
                if (customerCarCollector.type == "Van")
                {
                    animator.SetBool("KapıAnahtar", true);
                }
                else if (customerCarCollector.type == "Truck")
                {
                    animator.SetBool("DoorOpen", true);
                }
                return;
            }
        }




    }

    void Leaving()
    {
        leaving = true;
        Paying();
    }
    int kartonKutuSayısı;
    int tahtaKutuSayısı;
    int varilSayisi;
    int elektronikSayisi;
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
            else if (customerCarCollector.boxs[i].GetComponent<ItemControl>().type == "Varil")
            {
                varilSayisi++;
            }
            else if (customerCarCollector.boxs[i].GetComponent<ItemControl>().type == "Elektronik")
            {
                elektronikSayisi++;
            }

        }
        toplamUretilenPara = (elektronikSayisi * 6) + (varilSayisi * 4) + (tahtaKutuSayısı * 2) + kartonKutuSayısı;
        for (int i = 0; i < toplamUretilenPara; i++)
        {
            GameObject money = Instantiate(moneyPrefab, transform.position, moneyPrefab.transform.rotation);
            moneyHolder.AddNewItem(money.transform);
            moneyHolder.numOfItemsHolding++;
            Debug.LogWarning("ODeme sistemi");
        }
        kartonKutuSayısı = 0;
        tahtaKutuSayısı = 0;
        varilSayisi = 0;
        elektronikSayisi = 0;
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
