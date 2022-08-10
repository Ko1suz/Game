using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public Transform PlayerTransform;
    public float money = 0;
    public Animator moneyImageAnim;
    public ParticleSystem moneyParticles;
    public int paraDegeri = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // SetAnimFalse();
        gm = GetComponent<GameManager>();
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney()
    {
        money +=paraDegeri;
        moneyImageAnim.SetBool("MoneyAddAnim",true);
    }

    IEnumerator SetAnimFalse()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            moneyImageAnim.SetBool("MoneyAddAnim",false);
        }
    }
}
