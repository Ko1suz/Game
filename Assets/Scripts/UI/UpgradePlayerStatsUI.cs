using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePlayerStatsUI : MonoBehaviour
{
    public Text CarSpeedText;
    public Text CollectSpeedText;
    public Text CapacityText;

    public Button CarSpeedButton;
    public Button CollectSpeedButton;
    public Button CapacityButton;

    public Button TruckUpgradeButton;

    public Text CarSpeedButtonText;
    public Text CollectSpeedButtonText;
    public Text CapacityButtonText;

    public Text TruckUpgradeButtonText;


    int carSpeedUpgrade_requiredMoney = 200;
    int CollectSpeedUpgrade_requiredMoney = 500;
    int CapacityUpgrade_requiredMoney = 750;
    int TruckUpgrade_requiredMoney = 50000;

    PlayerStats playerStats;
    GameManager gm;

    private void Start()
    {
        gm = GameManager.gm;
        playerStats = PlayerStats.instance;
        Loading();
        UpdateValues();
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
        UpdateValues();
        playerStats.SetDefault();
        Loading();
        Debug.LogError("Çalışıyorum");
    }

    public void Loading()
    {
        playerStats.araçHizi = PlayerPrefs.GetFloat(nameof(playerStats.araçHizi),playerStats.araçHizi);
        playerStats.urunToplamaVeVermeHizi = PlayerPrefs.GetFloat(nameof(playerStats.urunToplamaVeVermeHizi),playerStats.urunToplamaVeVermeHizi);
        playerStats.maxItemTutmaSayisi = PlayerPrefs.GetInt(nameof(playerStats.maxItemTutmaSayisi),playerStats.maxItemTutmaSayisi);
    }

    public void UpdateValues()
    {
        CarSpeedText.text = "Vichle Speed =" + playerStats.araçHizi;
        CollectSpeedText.text = "Collect Speed =" + playerStats.urunToplamaVeVermeHizi;
        CapacityText.text = "Capacity =" + playerStats.maxItemTutmaSayisi;

        CarSpeedButtonText.text = carSpeedUpgrade_requiredMoney.ToString();
        CollectSpeedButtonText.text = CollectSpeedUpgrade_requiredMoney.ToString();
        CapacityButtonText.text = CapacityUpgrade_requiredMoney.ToString();

        TruckUpgradeButtonText.text = TruckUpgrade_requiredMoney.ToString();
    }

    public void UpgradeVichleSpeed()
    {
        if (gm.money >= carSpeedUpgrade_requiredMoney)
        {
            gm.money -= carSpeedUpgrade_requiredMoney;
            playerStats.araçHizi += 10;
            carSpeedUpgrade_requiredMoney += carSpeedUpgrade_requiredMoney * 4 / 10;
            CarSpeedButtonText.text = carSpeedUpgrade_requiredMoney.ToString();
            CarSpeedText.text = "Vichle Speed =" + playerStats.araçHizi;
            PlayerPrefs.SetFloat(nameof(playerStats.araçHizi),playerStats.araçHizi);
        }

        if (playerStats.araçHizi >= 200)
        {
            CarSpeedButton.interactable = false;
            CarSpeedButtonText.text = "Full";
        }
    }

    public void UpgradeCollectSpeed()
    {
        if (gm.money >= CollectSpeedUpgrade_requiredMoney)
        {
            gm.money -= CollectSpeedUpgrade_requiredMoney;
            playerStats.urunToplamaVeVermeHizi -= 0.1f;
            CollectSpeedUpgrade_requiredMoney += CollectSpeedUpgrade_requiredMoney * 3 / 10;
            CollectSpeedButtonText.text = CollectSpeedUpgrade_requiredMoney.ToString();
            CollectSpeedText.text = "Collect Speed =" + playerStats.urunToplamaVeVermeHizi;
            PlayerPrefs.SetFloat(nameof(playerStats.urunToplamaVeVermeHizi),playerStats.urunToplamaVeVermeHizi);
        }

        if (playerStats.urunToplamaVeVermeHizi <= 0.1f)
        {
            CollectSpeedButton.interactable = false;
            CollectSpeedButtonText.text = "Full";
        }
    }

    public void UpgradeCapacity()
    {
        if (gm.money >= CapacityUpgrade_requiredMoney)
        {
            gm.money -= CapacityUpgrade_requiredMoney;
            playerStats.maxItemTutmaSayisi += 1;
            CapacityUpgrade_requiredMoney += CapacityUpgrade_requiredMoney * 5 / 10;
            CapacityButtonText.text = CapacityUpgrade_requiredMoney.ToString();
            CapacityText.text = "Capacity =" + playerStats.maxItemTutmaSayisi;
            PlayerPrefs.SetInt(nameof(playerStats.maxItemTutmaSayisi),playerStats.maxItemTutmaSayisi);
        }

        if (playerStats.maxItemTutmaSayisi >= 10)
        {
            CapacityButtonText.text = "Full";
            CapacityButton.interactable = false;
        }
    }

    public void TruckUpgrade()
    {
        if (gm.money>=TruckUpgrade_requiredMoney)
        {   
            gm.money -= TruckUpgrade_requiredMoney;
            CustomerSpawner.LevelUp = true;
            TruckUpgradeButton.interactable = false;
            TruckUpgradeButtonText.text = "Full";
        }
        else
        {
            return;
        }
    }
}
