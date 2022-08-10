using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceData : MonoBehaviour
{
    public GameObject[] Places; // 12 Bölgeler
    public GameObject[] PlacesUpgradeUIs; // 12 UI
    public GameObject[] PlacesWalls; // 12 Walls
    public GameObject[] Producters; //6 Üreticiler
    public GameObject[] ProductersUpgradeUIs; //6 UI
    public GameObject[] FarAwayProducters; //4 Uzak Paletler
    public GameObject[] FarAwayProductersUpgradeUIs; //4 UI
    public GameObject[] CustomerPallets; // 10 Müşteri Paletleri
    public GameObject[] CustomerPalletsUpgradeUIs; //10 UI
    public GameObject[] AutomationSystems; // 6 Otomasyon sistemleri
    public GameObject[] AutomationSystemsUpgradeUIs; //6 UI
    public bool Reset = false;



    private void Start()
    {
        GetPlace();
        GetProducters();
        GetFarAwayProducters();
        GetCustomerPallets();
        GetAutomationSystems();
    }
    private void FixedUpdate()
    {
        if (!Reset)
        {
            SavePlace();
            SaveProducters();
            SaveFarAwayProducters();
            SaveCustomerPallets();
            SaveAutomationSystems();
        }
    }


    public void ReStart()
    {
        Reset = true;
        PlayerPrefs.DeleteAll();
        Debug.LogWarning("ReSet atıldı");
    }

    void SavePlace()
    {
        for (int i = 0; i < Places.Length; i++)
        {
            if (Places[i].gameObject.activeInHierarchy == true)
            {
                PlayerPrefs.SetInt("Place" + i, 1);
            }
            else if (Places[i].gameObject.activeInHierarchy == false)
            {
                PlayerPrefs.SetInt("Place" + i, 0);
            }
        }
    }

    void GetPlace()
    {
        for (int i = 0; i < Places.Length; i++)
        {
            int control = PlayerPrefs.GetInt("Place" + i);
            if (control == 1)
            {
                Places[i].gameObject.SetActive(true);
                Destroy(PlacesUpgradeUIs[i].gameObject); 
                Destroy(PlacesWalls[i].gameObject); 
            }
        }
    }


    void SaveProducters()
    {
        for (int i = 0; i < Producters.Length; i++)
        {
            if (Producters[i].gameObject.activeInHierarchy == true)
            {
                PlayerPrefs.SetInt("Producters" + i, 1);
            }
            else if (Producters[i].gameObject.activeInHierarchy == false)
            {
                PlayerPrefs.SetInt("Producters" + i, 0);
            }
        }
    }

    void GetProducters()
    {
        for (int i = 0; i < Producters.Length; i++)
        {
            int control = PlayerPrefs.GetInt("Producters" + i);
            if (control == 1)
            {
                Producters[i].gameObject.SetActive(true);
                Destroy(ProductersUpgradeUIs[i].gameObject); 
                
            }
        }
    }

    void SaveFarAwayProducters()
    {
        for (int i = 0; i < FarAwayProducters.Length; i++)
        {
            if (FarAwayProducters[i].gameObject.activeInHierarchy == true)
            {
                PlayerPrefs.SetInt("FarAwayProducters" + i, 1);
            }
            else if (FarAwayProducters[i].gameObject.activeInHierarchy == false)
            {
                PlayerPrefs.SetInt("FarAwayProducters" + i, 0);
            }
        }
    }

    void GetFarAwayProducters()
    {
        for (int i = 0; i < FarAwayProducters.Length; i++)
        {
            int control = PlayerPrefs.GetInt("FarAwayProducters" + i);
            if (control == 1)
            {
                FarAwayProducters[i].gameObject.SetActive(true);
                Destroy(FarAwayProductersUpgradeUIs[i].gameObject); 
            }
        }
    }
    void SaveCustomerPallets()
    {
        for (int i = 0; i < CustomerPallets.Length; i++)
        {
            if (CustomerPallets[i].gameObject.activeInHierarchy == true)
            {
                PlayerPrefs.SetInt("CustomerPallets" + i, 1);
            }
            else if (CustomerPallets[i].gameObject.activeInHierarchy == false)
            {
                PlayerPrefs.SetInt("CustomerPallets" + i, 0);
            }
        }
    }

    void GetCustomerPallets()
    {
        for (int i = 0; i < CustomerPallets.Length; i++)
        {
            int control = PlayerPrefs.GetInt("CustomerPallets" + i);
            if (control == 1)
            {
                CustomerPallets[i].gameObject.SetActive(true);
                Destroy(CustomerPalletsUpgradeUIs[i].gameObject); 
            }
        }
    }

    void SaveAutomationSystems()
    {
        for (int i = 0; i < AutomationSystems.Length; i++)
        {
            if (AutomationSystems[i].gameObject.activeInHierarchy == true)
            {
                PlayerPrefs.SetInt("AutomationSystems" + i, 1);
            }
            else if (AutomationSystems[i].gameObject.activeInHierarchy == false)
            {
                PlayerPrefs.SetInt("AutomationSystems" + i, 0);
            }
        }
    }

    void GetAutomationSystems()
    {
        for (int i = 0; i < AutomationSystems.Length; i++)
        {
            int control = PlayerPrefs.GetInt("AutomationSystems" + i);
            if (control == 1)
            {
                AutomationSystems[i].gameObject.SetActive(true);
                Destroy(AutomationSystemsUpgradeUIs[i].gameObject); 
            }
        }
    }
}
