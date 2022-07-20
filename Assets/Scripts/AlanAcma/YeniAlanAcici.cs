using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YeniAlanAcici : MonoBehaviour
{
    GameManager gm;
    public bool playerIsIn;
    public Image fill;
    public Text moneyText;
    public Slider slider;
    public Gradient gradient;
    public GameObject yeniAlan;
    public GameObject duvar;
    public float aktifEtmeSuresi = 0.5f;
    public float alanAcmaUcreti;
    public float mevcutPara = 0;


    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        slider.value = mevcutPara;
        slider.maxValue = alanAcmaUcreti;
        // StartCoroutine(AktifEt());
    }

    private void Update()
    {
        SetSliderUI();
        if (playerIsIn)
        {
            AlanAc();
        }
    }
    IEnumerator AktifEt()
    {
        while (true)
        {
            yield return new WaitForSeconds(aktifEtmeSuresi);
            if (playerIsIn)
            {
                AlanAc();
            }
        }
    }

    float a;
    float b = 0.01f;

    void AlanAc()
    {
        a += Time.deltaTime;
        if (a >= b && gm.money > 0)
        {
            takeMoney();
            if (mevcutPara >= alanAcmaUcreti)
            {
                if (duvar == null)
                {
                    yeniAlan.SetActive(true);
                    Destroy(this.gameObject);
                }
                else
                {
                    yeniAlan.SetActive(true);
                    duvar.SetActive(false);
                    Destroy(this.gameObject);
                }
            }
            a = 0;
        }
    }

    void takeMoney()
    {
        if (alanAcmaUcreti <= 3000)
        {
            mevcutPara += 5;
            gm.money -= 5;
        }
        else if(alanAcmaUcreti>3000 && alanAcmaUcreti<=10000)
        {
            mevcutPara += 25;
            gm.money -= 25;
        }
        else if (alanAcmaUcreti>10000 && alanAcmaUcreti<=30000)
        {
            mevcutPara += 50;
            gm.money -= 50;
        }

    }

    public void SetSliderUI()
    {
        slider.value = mevcutPara;
        moneyText.text = (alanAcmaUcreti - mevcutPara).ToString();
        moneyText.color = gradient.Evaluate(slider.normalizedValue);
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsIn = false;
        }
    }


}
