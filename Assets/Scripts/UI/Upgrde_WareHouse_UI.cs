using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrde_WareHouse_UI : MonoBehaviour
{
    
    [SerializeField] private Text productValue;
    [SerializeField] private Text bandSpeed;
    [SerializeField] private Text customerCarSpeed;
    [SerializeField] private Text customerSpawnDelay;
    [Header("Tier 1")]
    [SerializeField] private Text tier1ProductSpeed;
    [SerializeField] private Text tier1palletCapacity;
    [SerializeField] private Text tier1EkxtraProductSpeed;
    [Header("Tier 2")]
    [SerializeField] private Text tier2ProductSpeed;
    [SerializeField] private Text tier2palletCapacity;
    [SerializeField] private Text tier2EkxtraProductSpeed;
    [Header("Tier 3")]
    [SerializeField] private Text tier3ProductSpeed;
    [SerializeField] private Text tier3palletCapacity;
    [SerializeField] private Text tier3EkxtraProductSpeed;
    [Header("Tier 4")]
    [SerializeField] private Text tier4ProductSpeed;
    [SerializeField] private Text tier4palletCapacity;
    [SerializeField] private Text tier4EkxtraProductSpeed;
    [Header("Customer Pallets")]
    [SerializeField] private Text pallet_1;
    [SerializeField] private Text pallet_2;
    [SerializeField] private Text pallet_3;
    [SerializeField] private Text pallet_4;
    [SerializeField] private Text pallet_5;
    [SerializeField] private Text pallet_6;
    [Header("Otomasyon")]
    [SerializeField] private Text hookSpeed;
    [SerializeField] private Text hookSpawnDelay;
    [Header("FarAway Pallets")]
    [SerializeField] private Text tier1FarAwayPallet;
    [SerializeField] private Text tier2FarAwayPallet;
    [SerializeField] private Text tier3FarAwayPallet;
    [SerializeField] private Text tier4FarAwayPallet;


    [Header("AAAAAAAAAAAAAAAAAAAAAAAA")]
    [SerializeField] private Text productValueButtonText;
    [SerializeField] private Text bandSpeedButtonText;
    [SerializeField] private Text customerCarSpeedButtonText;
    [SerializeField] private Text customerSpawnDelayButtonText;
    [Header("Tier 1")]
    [SerializeField] private Text tier1ProductSpeedButtonText;
    [SerializeField] private Text tier1palletCapacityButtonText;
    [SerializeField] private Text tier1EkxtraProductSpeedButtonText;
    [Header("Tier 2")]
    [SerializeField] private Text tier2ProductSpeedButtonText;
    [SerializeField] private Text tier2palletCapacityButtonText;
    [SerializeField] private Text tier2EkxtraProductSpeedButtonText;
    [Header("Tier 3")]
    [SerializeField] private Text tier3ProductSpeedButtonText;
    [SerializeField] private Text tier3palletCapacityButtonText;
    [SerializeField] private Text tier3EkxtraProductSpeedButtonText;
    [Header("Tier 3")]
    [SerializeField] private Text tier4ProductSpeedButtonText;
    [SerializeField] private Text tier4palletCapacityButtonText;
    [SerializeField] private Text tier4EkxtraProductSpeedButtonText;
    [Header("Customer Pallets")]
    [SerializeField] private Text pallet_1ButtonText;
    [SerializeField] private Text pallet_2ButtonText;
    [SerializeField] private Text pallet_3ButtonText;
    [SerializeField] private Text pallet_4ButtonText;
    [SerializeField] private Text pallet_5ButtonText;
    [SerializeField] private Text pallet_6ButtonText;
    [Header("Otomasyon")]
    [SerializeField] private Text hookSpeedButtonText;
    [SerializeField] private Text hookSpawnDelayButtonText;
    [Header("FarAway Pallets")]
    [SerializeField] private Text tier1FarAwayPalletButtonText;
    [SerializeField] private Text tier2FarAwayPalletButtonText;
    [SerializeField] private Text tier3FarAwayPalletButtonText;
    [SerializeField] private Text tier4FarAwayPalletButtonText;


    [Header("OH I SEE, YOU DENY YOUR WEPON PORPUSE")]
    [SerializeField] private Button productValueButton;
    [SerializeField] private Button bandSpeedButton;
    [SerializeField] private Button customerCarSpeedButton;
    [SerializeField] private Button customerSpawnDelayButton;
    [Header("Tier 1")]
    [SerializeField] private Button tier1ProductSpeedButton;
    [SerializeField] private Button tier1palletCapacityButton;
    [SerializeField] private Button tier1EkxtraProductSpeedButton;
    [Header("Tier 2")]
    [SerializeField] private Button tier2ProductSpeedButton;
    [SerializeField] private Button tier2palletCapacityButton;
    [SerializeField] private Button tier2EkxtraProductSpeedButton;
    [Header("Tier 3")]
    [SerializeField] private Button tier3ProductSpeedButton;
    [SerializeField] private Button tier3palletCapacityButton;
    [SerializeField] private Button tier3EkxtraProductSpeedButton;
    [Header("Tier 4")]
    [SerializeField] private Button tier4ProductSpeedButton;
    [SerializeField] private Button tier4palletCapacityButton;
    [SerializeField] private Button tier4EkxtraProductSpeedButton;
    [Header("Customer Pallets")]
    [SerializeField] private Button pallet_1Button;
    [SerializeField] private Button pallet_2Button;
    [SerializeField] private Button pallet_3Button;
    [SerializeField] private Button pallet_4Button;
    [SerializeField] private Button pallet_5Button;
    [SerializeField] private Button pallet_6Button;
    [Header("Otomasyon")]
    [SerializeField] private Button hookSpeedButton;
    [SerializeField] private Button hookSpawnDelayButton;
    [Header("FarAway Pallets")]
    [SerializeField] private Button tier1FarAwayPalletButton;
    [SerializeField] private Button tier2FarAwayPalletButton;
    [SerializeField] private Button tier3FarAwayPalletButton;
    [SerializeField] private Button tier4FarAwayPalletButton;


    int ProductValueUpgrade_requiredMoney = 20;
    int bandSpeed_requiredMoney = 20;
    int customerCarSpeed_requiredMoney = 200;
    int customerSpawnDelay_requiredMoney = 200;
    int tier1ProductSpeed_requiredMoney = 300;
    int tier1palletCapacity_requiredMoney = 100;
    int tier1EkxtraProductSpeed_requiredMoney = 400;
    int tier2ProductSpeed_requiredMoney = 450;
    int tier2palletCapacity_requiredMoney = 200;
    int tier2EkxtraProductSpeed_requiredMoney = 550;
    int tier3ProductSpeed_requiredMoney = 450;
    int tier3palletCapacity_requiredMoney = 200;
    int tier3EkxtraProductSpeed_requiredMoney = 550;
    int tier4ProductSpeed_requiredMoney = 450;
    int tier4palletCapacity_requiredMoney = 200;
    int tier4EkxtraProductSpeed_requiredMoney = 550;
    int pallet_1_requiredMoney = 100;
    int pallet_2_requiredMoney = 150;
    int pallet_3_requiredMoney = 300;
    int pallet_4_requiredMoney = 500;
    int pallet_5_requiredMoney = 1000;
    int pallet_6_requiredMoney = 2000;
    int hookSpeed_requiredMoney = 1000;
    int hookSpawnDelay_requiredMoney = 1000;
    int tier1FarAwayPallet_requiredMoney = 1200;
    int tier2FarAwayPallet_requiredMoney = 1500;
    int tier3FarAwayPallet_requiredMoney = 2500;
    int tier4FarAwayPallet_requiredMoney = 5000;

    UpgradeStats upgradeStats;
    GameManager gm;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        // gm = GameManager.gm;
        upgradeStats = UpgradeStats.instance;
        Loading();
        UpdateValues();
    }


    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
        UpdateValues();
        upgradeStats.SetDefault();
        Loading();
        Debug.LogError("Çalışıyorum");
    }


    void Loading()
    {
        upgradeStats.urunKalitesi = PlayerPrefs.GetInt(nameof(upgradeStats.urunKalitesi), upgradeStats.urunKalitesi);
        upgradeStats.MusteriAracizi = PlayerPrefs.GetFloat(nameof(upgradeStats.MusteriAracizi), upgradeStats.MusteriAracizi);
        upgradeStats.MusteriGelmeSuresi = PlayerPrefs.GetFloat(nameof(upgradeStats.MusteriGelmeSuresi), upgradeStats.MusteriGelmeSuresi);

        upgradeStats.TierBirUretimBandiDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierBirUretimBandiDelayi), upgradeStats.TierBirUretimBandiDelayi);
        upgradeStats.TierBirUrunTutmaSayısı = PlayerPrefs.GetInt(nameof(upgradeStats.TierBirUrunTutmaSayısı), upgradeStats.TierBirUrunTutmaSayısı);
        upgradeStats.TierBirYanUretimBandıDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierBirYanUretimBandıDelayi), upgradeStats.TierBirYanUretimBandıDelayi);

        upgradeStats.TierIkiUretimBandiDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierIkiUretimBandiDelayi), upgradeStats.TierIkiUretimBandiDelayi);
        upgradeStats.TierIkiUrunTutmaSayısı = PlayerPrefs.GetInt(nameof(upgradeStats.TierIkiUrunTutmaSayısı), upgradeStats.TierIkiUrunTutmaSayısı);
        upgradeStats.TierIkiYanUretimBandıDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierIkiYanUretimBandıDelayi), upgradeStats.TierIkiYanUretimBandıDelayi);

        upgradeStats.TierUcUretimBandiDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierUcUretimBandiDelayi), upgradeStats.TierUcUretimBandiDelayi);
        upgradeStats.TierUcUrunTutmaSayısı = PlayerPrefs.GetInt(nameof(upgradeStats.TierUcUrunTutmaSayısı), upgradeStats.TierUcUrunTutmaSayısı);
        upgradeStats.TierUcYanUretimBandıDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierUcYanUretimBandıDelayi), upgradeStats.TierUcYanUretimBandıDelayi);

        upgradeStats.TierDortUretimBandiDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierDortUretimBandiDelayi), upgradeStats.TierDortUretimBandiDelayi);
        upgradeStats.TierDortUrunTutmaSayısı = PlayerPrefs.GetInt(nameof(upgradeStats.TierDortUrunTutmaSayısı), upgradeStats.TierDortUrunTutmaSayısı);
        upgradeStats.TierDortYanUretimBandıDelayi = PlayerPrefs.GetFloat(nameof(upgradeStats.TierDortYanUretimBandıDelayi), upgradeStats.TierDortYanUretimBandıDelayi);
        
        upgradeStats.Palet1UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet1UrunTutmaSayisi), upgradeStats.Palet1UrunTutmaSayisi);
        upgradeStats.Palet2UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet2UrunTutmaSayisi), upgradeStats.Palet2UrunTutmaSayisi);
        upgradeStats.Palet3UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet3UrunTutmaSayisi), upgradeStats.Palet3UrunTutmaSayisi);
        upgradeStats.Palet4UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet4UrunTutmaSayisi), upgradeStats.Palet4UrunTutmaSayisi);
        upgradeStats.Palet5UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet5UrunTutmaSayisi), upgradeStats.Palet5UrunTutmaSayisi);
        upgradeStats.Palet6UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.Palet6UrunTutmaSayisi), upgradeStats.Palet6UrunTutmaSayisi);

        upgradeStats.KancaHizi = PlayerPrefs.GetFloat(nameof(upgradeStats.KancaHizi), upgradeStats.KancaHizi);
        upgradeStats.KancaDelay = PlayerPrefs.GetFloat(nameof(upgradeStats.KancaDelay), upgradeStats.KancaDelay);

        upgradeStats.UzakPalet1UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.UzakPalet1UrunTutmaSayisi), upgradeStats.UzakPalet1UrunTutmaSayisi);
        upgradeStats.UzakPalet2UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.UzakPalet2UrunTutmaSayisi), upgradeStats.UzakPalet2UrunTutmaSayisi);
        upgradeStats.UzakPalet3UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.UzakPalet3UrunTutmaSayisi), upgradeStats.UzakPalet3UrunTutmaSayisi);
        upgradeStats.UzakPalet4UrunTutmaSayisi = PlayerPrefs.GetInt(nameof(upgradeStats.UzakPalet4UrunTutmaSayisi), upgradeStats.UzakPalet4UrunTutmaSayisi);

    }

    void UpdateValues()
    {
        productValue.text = "Urun Degeri = " + upgradeStats.urunKalitesi; //
        bandSpeed.text = "Bant Hizi = " + upgradeStats.kutularinHizi; //
        customerCarSpeed.text = "Musteri arac hizi = " + upgradeStats.MusteriAracizi; //
        customerSpawnDelay.text = "Musteri sikligi = " + upgradeStats.MusteriGelmeSuresi;//
        tier1ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierBirUretimBandiDelayi;//
        tier1palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierBirUrunTutmaSayısı;//
        tier1EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierBirYanUretimBandıDelayi;//
        tier2ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierIkiUretimBandiDelayi;//
        tier2palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierIkiUrunTutmaSayısı;//
        tier2EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierIkiYanUretimBandıDelayi;//
        tier3ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierUcUretimBandiDelayi;
        tier3palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierUcUrunTutmaSayısı;
        tier3EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierUcYanUretimBandıDelayi;
        tier4ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierDortUretimBandiDelayi;
        tier4palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierDortUrunTutmaSayısı;
        tier4EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierDortYanUretimBandıDelayi;
        pallet_1.text = "Kapasite = " + upgradeStats.Palet1UrunTutmaSayisi;//
        pallet_2.text = "Kapasite = " + upgradeStats.Palet2UrunTutmaSayisi;//
        pallet_3.text = "Kapasite = " + upgradeStats.Palet3UrunTutmaSayisi;//
        pallet_4.text = "Kapasite = " + upgradeStats.Palet4UrunTutmaSayisi;//
        pallet_5.text = "Kapasite = " + upgradeStats.Palet5UrunTutmaSayisi;
        pallet_6.text = "Kapasite = " + upgradeStats.Palet6UrunTutmaSayisi;
        hookSpeed.text = "Hiz = " + upgradeStats.KancaHizi;//
        hookSpawnDelay.text = "Delay = " + upgradeStats.KancaDelay;//
        tier1FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet1UrunTutmaSayisi;//
        tier2FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet2UrunTutmaSayisi;//
        tier3FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet3UrunTutmaSayisi;
        tier4FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet4UrunTutmaSayisi;

        productValueButtonText.text = ProductValueUpgrade_requiredMoney.ToString();//
        bandSpeedButtonText.text = bandSpeed_requiredMoney.ToString();//
        customerCarSpeedButtonText.text = customerCarSpeed_requiredMoney.ToString();//
        customerSpawnDelayButtonText.text = customerSpawnDelay_requiredMoney.ToString();//
        tier1ProductSpeedButtonText.text = tier1ProductSpeed_requiredMoney.ToString();//
        tier1palletCapacityButtonText.text = tier1palletCapacity_requiredMoney.ToString();//
        tier1EkxtraProductSpeedButtonText.text = tier1EkxtraProductSpeed_requiredMoney.ToString();//
        tier2ProductSpeedButtonText.text = tier2ProductSpeed_requiredMoney.ToString();//
        tier2palletCapacityButtonText.text = tier2palletCapacity_requiredMoney.ToString();//
        tier2EkxtraProductSpeedButtonText.text = tier2EkxtraProductSpeed_requiredMoney.ToString();//
        tier3ProductSpeedButtonText.text = tier3ProductSpeed_requiredMoney.ToString();
        tier3palletCapacityButtonText.text = tier3palletCapacity_requiredMoney.ToString();
        tier3EkxtraProductSpeedButtonText.text = tier3EkxtraProductSpeed_requiredMoney.ToString();
        tier4ProductSpeedButtonText.text = tier4ProductSpeed_requiredMoney.ToString();
        tier4palletCapacityButtonText.text = tier4palletCapacity_requiredMoney.ToString();
        tier4EkxtraProductSpeedButtonText.text = tier4EkxtraProductSpeed_requiredMoney.ToString();
        pallet_1ButtonText.text = pallet_1_requiredMoney.ToString();//
        pallet_2ButtonText.text = pallet_2_requiredMoney.ToString();//
        pallet_3ButtonText.text = pallet_3_requiredMoney.ToString();//
        pallet_4ButtonText.text = pallet_4_requiredMoney.ToString();//
        pallet_5ButtonText.text = pallet_4_requiredMoney.ToString();
        pallet_6ButtonText.text = pallet_4_requiredMoney.ToString();
        hookSpeedButtonText.text = hookSpeed_requiredMoney.ToString();//
        hookSpawnDelayButtonText.text = hookSpawnDelay_requiredMoney.ToString();//
        tier1FarAwayPalletButtonText.text = tier1FarAwayPallet_requiredMoney.ToString();//
        tier2FarAwayPalletButtonText.text = tier2FarAwayPallet_requiredMoney.ToString();//
        tier3FarAwayPalletButtonText.text = tier3FarAwayPallet_requiredMoney.ToString();
        tier4FarAwayPalletButtonText.text = tier4FarAwayPallet_requiredMoney.ToString();
    }

    public void UpgradeProductValue()
    {

        if (gm.money > ProductValueUpgrade_requiredMoney)
        {
            gm.money -= ProductValueUpgrade_requiredMoney;
            gm.paraDegeri += ((int)(upgradeStats.urunKalitesi * 1 / 10));
            upgradeStats.urunKalitesi += ((int)(upgradeStats.urunKalitesi * 1 / 10));
            ProductValueUpgrade_requiredMoney += (int)(ProductValueUpgrade_requiredMoney * 2 / 10);
            productValueButtonText.text = ProductValueUpgrade_requiredMoney.ToString();
            productValue.text = "Urun Degeri = " + upgradeStats.urunKalitesi;
            PlayerPrefs.SetInt(nameof(upgradeStats.urunKalitesi), upgradeStats.urunKalitesi);
        }

        if (upgradeStats.urunKalitesi >= 5000)
        {
            productValueButton.interactable = false;
            productValueButtonText.text = "Full";
        }
    }
    public void UpgradeBandSpeed()
    {

        if (gm.money > bandSpeed_requiredMoney)
        {
            gm.money -= bandSpeed_requiredMoney;
            upgradeStats.kutularinHizi += 0.04f;
            bandSpeed_requiredMoney += (int)(bandSpeed_requiredMoney * 1 / 10);
            bandSpeedButtonText.text = bandSpeed_requiredMoney.ToString();
            bandSpeed.text = "Bant Hizi = " + upgradeStats.kutularinHizi;

        }

        if (upgradeStats.kutularinHizi >= 0.6f)
        {
            bandSpeedButton.interactable = false;
            bandSpeedButtonText.text = "Full";
        }
    }
    public void UpgradeCustomerCarSpeed()
    {

        if (gm.money > customerCarSpeed_requiredMoney)
        {
            gm.money -= customerCarSpeed_requiredMoney;
            upgradeStats.MusteriAracizi += 0.1f;
            customerCarSpeed_requiredMoney += (int)(customerCarSpeed_requiredMoney * 3 / 10);
            customerCarSpeedButtonText.text = customerCarSpeed_requiredMoney.ToString();
            customerCarSpeed.text = "Musteri arac hizi = " + upgradeStats.MusteriAracizi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.MusteriAracizi), upgradeStats.MusteriAracizi);
        }

        if (upgradeStats.MusteriAracizi >= 1)
        {
            customerCarSpeedButtonText.text = "Full";
            customerCarSpeedButton.interactable = false;
        }
    }
    public void UpgradeCustomerDelay()
    {

        if (gm.money > customerSpawnDelay_requiredMoney)
        {
            gm.money -= customerSpawnDelay_requiredMoney;
            upgradeStats.MusteriGelmeSuresi -= 0.3f;
            customerSpawnDelay_requiredMoney += (int)(customerSpawnDelay_requiredMoney * 3 / 10);
            customerSpawnDelayButtonText.text = customerSpawnDelay_requiredMoney.ToString();
            customerSpawnDelay.text = "Musteri sikligi = " + upgradeStats.MusteriGelmeSuresi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.MusteriGelmeSuresi), upgradeStats.MusteriGelmeSuresi);
        }

        if (upgradeStats.MusteriGelmeSuresi <= 0.8f)
        {
            customerSpawnDelayButton.interactable = false;
            customerSpawnDelayButtonText.text = "Full";
        }
    }
    public void UpgradeTier1ProductSpeed()
    {

        if (gm.money > tier1ProductSpeed_requiredMoney)
        {
            gm.money -= tier1ProductSpeed_requiredMoney;
            upgradeStats.TierBirUretimBandiDelayi -= 0.5f;
            tier1ProductSpeed_requiredMoney += (int)(tier1ProductSpeed_requiredMoney * 3 / 10);
            tier1ProductSpeedButtonText.text = tier1ProductSpeed_requiredMoney.ToString();
            tier1ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierBirUretimBandiDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierBirUretimBandiDelayi), upgradeStats.TierBirUretimBandiDelayi);
        }

        if (upgradeStats.TierBirUretimBandiDelayi < 2f)
        {
            tier1ProductSpeedButton.interactable = false;
            tier1ProductSpeedButtonText.text = "Full";
            tier1ProductSpeedButton.enabled = false;
        }
    }

    public void UpgradeTier1PalletCapacity()
    {

        if (gm.money > tier1palletCapacity_requiredMoney)
        {
            gm.money -= tier1palletCapacity_requiredMoney;
            upgradeStats.TierBirUrunTutmaSayısı += 5;
            tier1palletCapacity_requiredMoney += (int)(tier1palletCapacity_requiredMoney * 3 / 10);
            tier1palletCapacityButtonText.text = tier1palletCapacity_requiredMoney.ToString();
            tier1palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierBirUrunTutmaSayısı;
            PlayerPrefs.SetInt(nameof(upgradeStats.TierBirUrunTutmaSayısı), upgradeStats.TierBirUrunTutmaSayısı);
            if (upgradeStats.TierBirUrunTutmaSayısı >= 50)
            {
                tier1palletCapacityButton.interactable = false;
                tier1palletCapacityButtonText.text = "Full";
            }
        }
    }
    public void UpgradeTier1EkxtraProductSpeed()
    {

        if (gm.money > tier1EkxtraProductSpeed_requiredMoney)
        {
            gm.money -= tier1EkxtraProductSpeed_requiredMoney;
            upgradeStats.TierBirYanUretimBandıDelayi -= 0.5f;
            tier1EkxtraProductSpeed_requiredMoney += (int)(tier1EkxtraProductSpeed_requiredMoney * 3 / 10);
            tier1EkxtraProductSpeedButtonText.text = tier1EkxtraProductSpeed_requiredMoney.ToString();
            tier1EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierBirYanUretimBandıDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierBirYanUretimBandıDelayi), upgradeStats.TierBirYanUretimBandıDelayi);
            if (upgradeStats.TierBirYanUretimBandıDelayi <= 0.7f)
            {
                tier1EkxtraProductSpeedButton.interactable = false;
                tier1EkxtraProductSpeedButtonText.text = "Full";
            }
        }
    }

    public void UpgradeTier2ProductSpeed()
    {

        if (gm.money > tier2ProductSpeed_requiredMoney)
        {
            gm.money -= tier2ProductSpeed_requiredMoney;
            upgradeStats.TierIkiUretimBandiDelayi -= 0.5f;
            tier2ProductSpeed_requiredMoney += (int)(tier2ProductSpeed_requiredMoney * 3 / 10);
            tier2ProductSpeedButtonText.text = tier2ProductSpeed_requiredMoney.ToString();
            tier2ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierIkiUretimBandiDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierIkiUretimBandiDelayi), upgradeStats.TierIkiUretimBandiDelayi);
            if (upgradeStats.TierIkiUretimBandiDelayi <= 0.7f)
            {
                tier2ProductSpeedButton.interactable = false;
                tier2ProductSpeedButtonText.text = "Full";
            }
        }
    }

    public void UpgradeTier2PalletCapacity()
    {

        if (gm.money > tier2palletCapacity_requiredMoney)
        {
            gm.money -= tier2palletCapacity_requiredMoney;
            upgradeStats.TierIkiUrunTutmaSayısı += 5;
            tier2palletCapacity_requiredMoney += (int)(tier2palletCapacity_requiredMoney * 3 / 10);
            tier2palletCapacityButtonText.text = tier2palletCapacity_requiredMoney.ToString();
            tier2palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierIkiUrunTutmaSayısı;
            PlayerPrefs.SetInt(nameof(upgradeStats.TierIkiUrunTutmaSayısı), upgradeStats.TierIkiUrunTutmaSayısı);
            if (upgradeStats.TierIkiUrunTutmaSayısı >= 50)
            {
                tier2palletCapacityButton.interactable = false;
                tier2palletCapacityButtonText.text = "Full";
            }
        }
    }

    public void UpgradeTier2EkxtraProductSpeed()
    {

        if (gm.money > tier2EkxtraProductSpeed_requiredMoney)
        {
            gm.money -= tier2EkxtraProductSpeed_requiredMoney;
            upgradeStats.TierIkiYanUretimBandıDelayi -= 0.5f;
            tier2EkxtraProductSpeed_requiredMoney += (int)(tier2EkxtraProductSpeed_requiredMoney * 3 / 10);
            tier2EkxtraProductSpeedButtonText.text = tier2EkxtraProductSpeed_requiredMoney.ToString();
            tier2EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierIkiYanUretimBandıDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierIkiYanUretimBandıDelayi), upgradeStats.TierIkiYanUretimBandıDelayi);
            if (upgradeStats.TierIkiYanUretimBandıDelayi <= 0.7f)
            {
                tier2EkxtraProductSpeedButton.interactable = false;
                tier2EkxtraProductSpeedButtonText.text = "Full";
            }
        }
    }

    public void UpgradeTier3ProductSpeed()
    {

        if (gm.money > tier3ProductSpeed_requiredMoney)
        {
            gm.money -= tier3ProductSpeed_requiredMoney;
            upgradeStats.TierUcUretimBandiDelayi -= 0.5f;
            tier3ProductSpeed_requiredMoney += (int)(tier3ProductSpeed_requiredMoney * 3 / 10);
            tier3ProductSpeedButtonText.text = tier3ProductSpeed_requiredMoney.ToString();
            tier3ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierUcUretimBandiDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierUcUretimBandiDelayi), upgradeStats.TierUcUretimBandiDelayi);
        }

        if (upgradeStats.TierUcUretimBandiDelayi < 2f)
        {
            tier3ProductSpeedButton.interactable = false;
            tier3ProductSpeedButtonText.text = "Full";
        }
    }

    public void UpgradeTier3PalletCapacity()
    {

        if (gm.money > tier3palletCapacity_requiredMoney)
        {
            gm.money -= tier3palletCapacity_requiredMoney;
            upgradeStats.TierUcUrunTutmaSayısı += 5;
            tier3palletCapacity_requiredMoney += (int)(tier3palletCapacity_requiredMoney * 3 / 10);
            tier3palletCapacityButtonText.text = tier3palletCapacity_requiredMoney.ToString();
            tier3palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierUcUrunTutmaSayısı;
            PlayerPrefs.SetInt(nameof(upgradeStats.TierUcUrunTutmaSayısı), upgradeStats.TierUcUrunTutmaSayısı);
            if (upgradeStats.TierUcUrunTutmaSayısı >= 50)
            {
                tier3palletCapacityButton.interactable = false;
                tier3palletCapacityButtonText.text = "Full";
            }
        }
    }
    public void UpgradeTier3EkxtraProductSpeed()
    {

        if (gm.money > tier3EkxtraProductSpeed_requiredMoney)
        {
            gm.money -= tier3EkxtraProductSpeed_requiredMoney;
            upgradeStats.TierUcYanUretimBandıDelayi -= 0.5f;
            tier3EkxtraProductSpeed_requiredMoney += (int)(tier3EkxtraProductSpeed_requiredMoney * 3 / 10);
            tier3EkxtraProductSpeedButtonText.text = tier3EkxtraProductSpeed_requiredMoney.ToString();
            tier3EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierUcYanUretimBandıDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierUcYanUretimBandıDelayi), upgradeStats.TierUcYanUretimBandıDelayi);

            if (upgradeStats.TierUcYanUretimBandıDelayi <= 0.7f)
            {
                tier3EkxtraProductSpeedButton.interactable = false;
                tier3EkxtraProductSpeedButtonText.text = "Full";
            }
        }
    }

    public void UpgradeTier4ProductSpeed()
    {

        if (gm.money > tier4ProductSpeed_requiredMoney)
        {
            gm.money -= tier4ProductSpeed_requiredMoney;
            upgradeStats.TierDortUretimBandiDelayi -= 0.5f;
            tier4ProductSpeed_requiredMoney += (int)(tier4ProductSpeed_requiredMoney * 3 / 10);
            tier4ProductSpeedButtonText.text = tier4ProductSpeed_requiredMoney.ToString();
            tier4ProductSpeed.text = "Uretim hizi = " + upgradeStats.TierDortUretimBandiDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierDortUretimBandiDelayi), upgradeStats.TierDortUretimBandiDelayi);

        }

        if (upgradeStats.TierDortUretimBandiDelayi < 2f)
        {
            tier4ProductSpeedButton.interactable = false;
            tier4ProductSpeedButtonText.text = "Full";
        }
    }

    public void UpgradeTier4PalletCapacity()
    {

        if (gm.money > tier4palletCapacity_requiredMoney)
        {
            gm.money -= tier4palletCapacity_requiredMoney;
            upgradeStats.TierDortUrunTutmaSayısı += 5;
            tier4palletCapacity_requiredMoney += (int)(tier4palletCapacity_requiredMoney * 3 / 10);
            tier4palletCapacityButtonText.text = tier4palletCapacity_requiredMoney.ToString();
            tier4palletCapacity.text = "Palet Kapasitesi = " + upgradeStats.TierDortUrunTutmaSayısı;
            PlayerPrefs.SetInt(nameof(upgradeStats.TierDortUrunTutmaSayısı), upgradeStats.TierDortUrunTutmaSayısı);

            if (upgradeStats.TierDortUrunTutmaSayısı >= 50)
            {
                tier4palletCapacityButton.interactable = false;
                tier4palletCapacityButtonText.text = "Full";
            }
        }
    }
    public void UpgradeTier4EkxtraProductSpeed()
    {

        if (gm.money > tier4EkxtraProductSpeed_requiredMoney)
        {
            gm.money -= tier4EkxtraProductSpeed_requiredMoney;
            upgradeStats.TierDortYanUretimBandıDelayi -= 0.5f;
            tier4EkxtraProductSpeed_requiredMoney += (int)(tier4EkxtraProductSpeed_requiredMoney * 3 / 10);
            tier4EkxtraProductSpeedButtonText.text = tier4EkxtraProductSpeed_requiredMoney.ToString();
            tier4EkxtraProductSpeed.text = "Ekstra Uretim Hizi = " + upgradeStats.TierDortYanUretimBandıDelayi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.TierDortYanUretimBandıDelayi), upgradeStats.TierDortYanUretimBandıDelayi);

            if (upgradeStats.TierDortYanUretimBandıDelayi <= 0.7f)
            {
                tier4EkxtraProductSpeedButton.interactable = false;
                tier4EkxtraProductSpeedButtonText.text = "Full";
            }
        }
    }
    public void UpgradeTierPallet1Capacity()
    {

        if (gm.money > pallet_1_requiredMoney)
        {
            gm.money -= pallet_1_requiredMoney;
            upgradeStats.Palet1UrunTutmaSayisi += 5;
            pallet_1_requiredMoney += (int)(pallet_1_requiredMoney * 3 / 10);
            pallet_1ButtonText.text = pallet_1_requiredMoney.ToString();
            pallet_1.text = "Kapasite = " + upgradeStats.Palet1UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet1UrunTutmaSayisi), upgradeStats.Palet1UrunTutmaSayisi);
            if (upgradeStats.Palet1UrunTutmaSayisi >= 50)
            {
                pallet_1Button.interactable = false;
                pallet_1ButtonText.text = "Full";
            }
        }
    }
    public void UpgradeTierPallet2Capacity()
    {

        if (gm.money > pallet_2_requiredMoney)
        {
            gm.money -= pallet_2_requiredMoney;
            upgradeStats.Palet2UrunTutmaSayisi += 5;
            pallet_2_requiredMoney += (int)(pallet_2_requiredMoney * 3 / 10);
            pallet_2ButtonText.text = pallet_2_requiredMoney.ToString();
            pallet_2.text = "Kapasite = " + upgradeStats.Palet2UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet2UrunTutmaSayisi), upgradeStats.Palet2UrunTutmaSayisi);
        }
        if (upgradeStats.Palet2UrunTutmaSayisi >= 50)
        {
            pallet_2Button.interactable = false;
            pallet_2ButtonText.text = "Full";
        }
    }
    public void UpgradeTierPallet3Capacity()
    {

        if (gm.money > pallet_3_requiredMoney)
        {
            gm.money -= pallet_3_requiredMoney;
            upgradeStats.Palet3UrunTutmaSayisi += 5;
            pallet_3_requiredMoney += (int)(pallet_3_requiredMoney * 3 / 10);
            pallet_3ButtonText.text = pallet_3_requiredMoney.ToString();
            pallet_3.text = "Kapasite = " + upgradeStats.Palet3UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet3UrunTutmaSayisi), upgradeStats.Palet3UrunTutmaSayisi);
        }
        if (upgradeStats.Palet3UrunTutmaSayisi >= 50)
        {
            pallet_3Button.interactable = false;
            pallet_3ButtonText.text = "Full";
        }
    }
    public void UpgradeTierPallet4Capacity()
    {

        if (gm.money > pallet_4_requiredMoney)
        {
            gm.money -= pallet_4_requiredMoney;
            upgradeStats.Palet4UrunTutmaSayisi += 5;
            pallet_4_requiredMoney += (int)(pallet_4_requiredMoney * 3 / 10);
            pallet_4ButtonText.text = pallet_4_requiredMoney.ToString();
            pallet_4.text = "Kapasite = " + upgradeStats.Palet4UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet4UrunTutmaSayisi), upgradeStats.Palet4UrunTutmaSayisi);
        }

        if (upgradeStats.Palet4UrunTutmaSayisi >= 50)
        {
            pallet_4Button.interactable = false;
            pallet_4ButtonText.text = "Full";
        }
    }
    public void UpgradeTierPallet5Capacity()
    {

        if (gm.money > pallet_5_requiredMoney)
        {
            gm.money -= pallet_5_requiredMoney;
            upgradeStats.Palet5UrunTutmaSayisi += 5;
            pallet_5_requiredMoney += (int)(pallet_5_requiredMoney * 3 / 10);
            pallet_5ButtonText.text = pallet_5_requiredMoney.ToString();
            pallet_5.text = "Kapasite = " + upgradeStats.Palet5UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet5UrunTutmaSayisi), upgradeStats.Palet5UrunTutmaSayisi);
        }

        if (upgradeStats.Palet5UrunTutmaSayisi >= 50)
        {
            pallet_5Button.interactable = false;
            pallet_5ButtonText.text = "Full";
        }
    }
    public void UpgradeTierPallet6Capacity()
    {

        if (gm.money > pallet_6_requiredMoney)
        {
            gm.money -= pallet_6_requiredMoney;
            upgradeStats.Palet6UrunTutmaSayisi += 5;
            pallet_6_requiredMoney += (int)(pallet_6_requiredMoney * 3 / 10);
            pallet_6ButtonText.text = pallet_6_requiredMoney.ToString();
            pallet_6.text = "Kapasite = " + upgradeStats.Palet6UrunTutmaSayisi;
            PlayerPrefs.SetInt(nameof(upgradeStats.Palet6UrunTutmaSayisi), upgradeStats.Palet6UrunTutmaSayisi);
        }

        if (upgradeStats.Palet4UrunTutmaSayisi >= 50)
        {
            pallet_6Button.interactable = false;
            pallet_6ButtonText.text = "Full";
        }
    }

    public void UpgradeHookSpeed()
    {

        if (gm.money > hookSpeed_requiredMoney)
        {
            gm.money -= hookSpeed_requiredMoney;
            upgradeStats.KancaHizi += 0.01f;
            hookSpeed_requiredMoney += (int)(hookSpeed_requiredMoney * 3 / 10);
            hookSpeedButtonText.text = hookSpeed_requiredMoney.ToString();
            hookSpeed.text = "Hiz = " + upgradeStats.KancaHizi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.KancaHizi), upgradeStats.KancaHizi);
            if (upgradeStats.KancaHizi >= 0.21f)
            {
                hookSpeedButton.interactable = false;
                hookSpeedButtonText.text = "Full";
            }
        }
    }
    public void UpgradeHookDelay()
    {

        if (gm.money > hookSpawnDelay_requiredMoney)
        {
            gm.money -= hookSpawnDelay_requiredMoney;
            upgradeStats.KancaDelay -= 0.5f;
            hookSpawnDelay_requiredMoney += (int)(hookSpawnDelay_requiredMoney * 3 / 10);
            hookSpawnDelayButtonText.text = hookSpawnDelay_requiredMoney.ToString();
            hookSpawnDelay.text = "Delay = " + upgradeStats.KancaDelay;
            PlayerPrefs.SetFloat(nameof(upgradeStats.KancaDelay), upgradeStats.KancaDelay);
            if (upgradeStats.KancaDelay <= 0.8f)
            {
                hookSpawnDelayButton.interactable = false;
                hookSpawnDelayButtonText.text = "Full";
            }

        }
    }

    public void Upgradetier1FarAwayPalletCapacity()
    {

        if (gm.money > tier1FarAwayPallet_requiredMoney)
        {
            gm.money -= tier1FarAwayPallet_requiredMoney;
            upgradeStats.UzakPalet1UrunTutmaSayisi += 5;
            tier1FarAwayPallet_requiredMoney += (int)(tier1FarAwayPallet_requiredMoney * 3 / 10);
            tier1FarAwayPalletButtonText.text = tier1FarAwayPallet_requiredMoney.ToString();
            tier1FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet1UrunTutmaSayisi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.UzakPalet1UrunTutmaSayisi), upgradeStats.UzakPalet1UrunTutmaSayisi);
            if (upgradeStats.UzakPalet1UrunTutmaSayisi >= 50)
            {
                tier1FarAwayPalletButton.interactable = false;
                tier1FarAwayPalletButtonText.text = "Full";
            }

        }
    }
    public void Upgradetier2FarAwayPalletCapacity()
    {

        if (gm.money > tier2FarAwayPallet_requiredMoney)
        {
            gm.money -= tier2palletCapacity_requiredMoney;
            upgradeStats.UzakPalet2UrunTutmaSayisi += 5;
            tier2FarAwayPallet_requiredMoney += (int)(tier2palletCapacity_requiredMoney * 3 / 10);
            tier2FarAwayPalletButtonText.text = tier2FarAwayPallet_requiredMoney.ToString();
            tier2FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet2UrunTutmaSayisi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.UzakPalet2UrunTutmaSayisi), upgradeStats.UzakPalet2UrunTutmaSayisi);
            if (upgradeStats.UzakPalet2UrunTutmaSayisi >= 50)
            {
                tier2FarAwayPalletButton.interactable = false;
                tier2FarAwayPalletButtonText.text = "Full";
            }
        }
    }
    public void Upgradetier3FarAwayPalletCapacity()
    {

        if (gm.money > tier3FarAwayPallet_requiredMoney)
        {
            gm.money -= tier3palletCapacity_requiredMoney;
            upgradeStats.UzakPalet3UrunTutmaSayisi += 5;
            tier3FarAwayPallet_requiredMoney += (int)(tier3palletCapacity_requiredMoney * 3 / 10);
            tier3FarAwayPalletButtonText.text = tier3FarAwayPallet_requiredMoney.ToString();
            tier3FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet3UrunTutmaSayisi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.UzakPalet3UrunTutmaSayisi), upgradeStats.UzakPalet3UrunTutmaSayisi);
            if (upgradeStats.UzakPalet3UrunTutmaSayisi >= 50)
            {
                tier3FarAwayPalletButton.interactable = false;
                tier3FarAwayPalletButtonText.text = "Full";
            }
        }
    }
    public void Upgradetier4FarAwayPalletCapacity()
    {

        if (gm.money > tier4FarAwayPallet_requiredMoney)
        {
            gm.money -= tier4palletCapacity_requiredMoney;
            upgradeStats.UzakPalet4UrunTutmaSayisi += 5;
            tier4FarAwayPallet_requiredMoney += (int)(tier4palletCapacity_requiredMoney * 3 / 10);
            tier4FarAwayPalletButtonText.text = tier4FarAwayPallet_requiredMoney.ToString();
            tier4FarAwayPallet.text = "Kapasite = " + upgradeStats.UzakPalet4UrunTutmaSayisi;
            PlayerPrefs.SetFloat(nameof(upgradeStats.UzakPalet4UrunTutmaSayisi), upgradeStats.UzakPalet4UrunTutmaSayisi);
            if (upgradeStats.UzakPalet4UrunTutmaSayisi >= 50)
            {
                tier4FarAwayPalletButton.interactable = false;
                tier4FarAwayPalletButtonText.text = "Full";
            }
        }
    }
}
