using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public GameObject playerUpgradeUI;
    public float a = 0;
    public float beklemeSuresi = 2f;
    public bool PlayerIn;


    public Image fill;
    public Image simge;
    public Slider slider;
    public Gradient gradient;

    private void Start() {
        slider.maxValue = beklemeSuresi;
    }
    private void Update() {
        SetSliderUI();
        if (PlayerIn)
        {
            UIOpen();
        }
    }
    void UIOpen()
    {   
        if (a<beklemeSuresi)
        {
            a += Time.deltaTime;
        }
        if (a >= beklemeSuresi)
        {
            playerUpgradeUI.SetActive(true);
        }

        if (!PlayerIn)
        {
            a = 0;
        }

    }

    public void SetSliderUI()
    {
        slider.value = a;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        simge.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerIn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerIn = false;
            a = 0;
            playerUpgradeUI.SetActive(false);
        }
    }
}
