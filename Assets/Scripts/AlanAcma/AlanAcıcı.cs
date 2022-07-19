using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlanAcıcı : MonoBehaviour
{
    GameManager gm;
    public GameObject yeniAlan;
    public GameObject duvar;
    public float alanAcmaSuresi = 5f;
    public float varsayılanAlanAcmaSuresi;
    // Start is called before the first frame update
    void Start()
    {
        varsayılanAlanAcmaSuresi = alanAcmaSuresi;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }

    private void Update()
    {
        AlanAc();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            alanAcmaSuresi -= Time.deltaTime;
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
        if (gm.money >= 150 && alanAcmaSuresi <= 0)
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
            alanAcmaSuresi = varsayılanAlanAcmaSuresi;
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
