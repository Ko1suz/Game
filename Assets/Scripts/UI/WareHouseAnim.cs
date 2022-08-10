using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouseAnim : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SagaKaydir_1()
    {
        animator.SetTrigger("Sag1");
    }
    public void SolaKaydir_1()
    {
        animator.SetTrigger("Sol1");
    }
   
}
