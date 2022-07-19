using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlanAcıcı : MonoBehaviour
{
    GameManager gm;
    public Slider slider;
    public GameObject yeniAlan;
    public GameObject duvar;
    public bool playerisIn;
    public float mevcutToplananPara = 0;
    public float alanAcmaUcreti = 5f;
    public float varsayılanAlanAcmaSuresi;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = mevcutToplananPara;
        slider.maxValue = alanAcmaUcreti;
        varsayılanAlanAcmaSuresi = alanAcmaUcreti;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }

    private void Update()
    {
        AlanAc();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerisIn = true;
            // StartCoroutine(AlanAcma());
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            playerisIn = false;
            // StartCoroutine(AlanAcma());
        }
    }

    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //         StopCoroutine(AlanAcma());
    //     }
    // }

    void AlanAc()
    {
        if (gm.money >= 150 && mevcutToplananPara >= alanAcmaUcreti)
        {
            if (duvar == null)
            {
                yeniAlan.SetActive(true);
                Destroy(this.gameObject);
            }
            else
            {
                duvar.SetActive(false);
                yeniAlan.SetActive(true);
                Destroy(this.gameObject);
            }
            gm.money -= 150;
        }
        else if (gm.money < 150)
        {
            alanAcmaUcreti = varsayılanAlanAcmaSuresi;
        }

    }

    // IEnumerator AlanAcma()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(3f);
    //         if (gm.money >= 150)
    //         {
    //             duvar.SetActive(false);
    //             yeniAlan.SetActive(true);
    //             Destroy(this.gameObject);
    //         }
    //         else
    //         {
    //             yield return null;
    //         }
    //     }
    // }
}
