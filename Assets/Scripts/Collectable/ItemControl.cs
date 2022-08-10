using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public string type = "KartonKutu";
    public bool turnWay = false;
    public bool isAlredyCollected = false;
    public bool isAlredyCollectedPalet = false;
    public bool isAlredyCollectedHoleCollector = false;
    public float speed;
    public bool yonunu180DereceDegistir;
    public bool Y_ekseni_hareket_yonu;
    public float Y_ekseni_hareket_hizi = 0;
    public bool Z_eksini_hareket_yonu;
    public float Z_eksini_hareket_hizi = 0;
    public bool isJumped = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isAlredyCollectedPalet || isAlredyCollectedHoleCollector)
        {
            this.speed = 0;
            this.Z_eksini_hareket_hizi = 0;
            return;
        }
        else if (other.CompareTag("HoleCollector"))
        {
            other.gameObject.GetComponent<HoleCollector>().Jump(this.transform);
            isJumped =  true;
            isAlredyCollectedHoleCollector = true;
            this.speed = 0;
            this.Z_eksini_hareket_hizi = 0;
        }
        else if (other.CompareTag("UretimPaleti"))
        {
            Collector collector;
            if (other.TryGetComponent(out collector) && collector.numOfItemsHolding <= collector.maxItemHold)
            {
                collector.AddNewItem(this.transform);
                isAlredyCollectedPalet = true;
                this.speed = 0;
            }
        }
        else if (other.CompareTag("UzakUretimPaleti"))
        {
            FarAwayCollector collector;
            if (other.TryGetComponent(out collector) && collector.numOfItemsHolding <= collector.maxItemHold)
            {
                collector.AddNewItem(this.transform);
                isAlredyCollectedPalet = true;
                this.speed = 0;
            }
        }

    }

    private void FixedUpdate()
    {
        Move();
        TurnWay();
    }

    void TurnWay()
    {
        if (transform.position.x <= 19.378 && turnWay && type=="KartonKutu" && !isJumped)
        {
            speed =0;
            Z_eksini_hareket_yonu = true;
            Z_eksini_hareket_hizi = 0.04f;
        }
        else if (transform.position.x <= 19.378 && turnWay && type=="TahtaKutu" &&!isJumped)
        {
            speed =0;
            Z_eksini_hareket_yonu = false;
            Z_eksini_hareket_hizi = 0.04f;
        }
        else if (transform.position.x <= 19.378 && turnWay && type=="Varil" &&!isJumped)
        {
            speed =0;
            Z_eksini_hareket_yonu = false;
            Z_eksini_hareket_hizi = 0.04f;
        }
        else if (transform.position.x <= 19.378 && turnWay && type=="Elektronik" &&!isJumped)
        {
            speed =0;
            Z_eksini_hareket_yonu = false;
            Z_eksini_hareket_hizi = 0.04f;
        }

    }

    protected void Move()
    {
        if (Y_ekseni_hareket_yonu)
        {
            transform.position += Vector3.up * Y_ekseni_hareket_hizi;
        }
        else if (!Y_ekseni_hareket_yonu)
        {
            transform.position += Vector3.up * -Y_ekseni_hareket_hizi;
        }

        if (Z_eksini_hareket_yonu)
        {
            transform.position += Vector3.forward * Z_eksini_hareket_hizi;
        }
        else if (!Z_eksini_hareket_yonu)
        {
            transform.position += Vector3.forward * -Z_eksini_hareket_hizi;
        }

        if (isAlredyCollected == false && !yonunu180DereceDegistir)
        {
            transform.position += Vector3.right * -speed;
        }
        else if (isAlredyCollected == false && yonunu180DereceDegistir)
        {
            transform.position += Vector3.left * -speed;
        }
    }
}
