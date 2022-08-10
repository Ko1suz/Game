using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeStats : MonoBehaviour
{
    public static UpgradeStats instance;

    public int urunKalitesi = 10;
    [Header("Üretim cihazları")]
    public float TierBirUretimBandiDelayi = 8;
    public float TierIkiUretimBandiDelayi = 8;
    public float TierUcUretimBandiDelayi = 8;
    public float TierDortUretimBandiDelayi = 8;
    public float TierBirYanUretimBandıDelayi = 8;
    public float TierIkiYanUretimBandıDelayi = 8;
    public float TierUcYanUretimBandıDelayi = 8;
    public float TierDortYanUretimBandıDelayi = 8;
    public int TierBirUrunTutmaSayısı = 10;
    public int TierIkiUrunTutmaSayısı = 10;
    public int TierUcUrunTutmaSayısı = 10;
    public int TierDortUrunTutmaSayısı = 10;
    public float kutularinHizi = 0.04f;
    [Header("Paletler")]
    public int Palet1UrunTutmaSayisi = 10;
    public int Palet2UrunTutmaSayisi = 10;
    public int Palet3UrunTutmaSayisi = 10;
    public int Palet4UrunTutmaSayisi = 10;
    public int Palet5UrunTutmaSayisi = 10;
    public int Palet6UrunTutmaSayisi = 10;
    [Header("UzakPaletler")]
    public int UzakPalet1UrunTutmaSayisi = 10;
    public int UzakPalet2UrunTutmaSayisi = 10;
    public int UzakPalet3UrunTutmaSayisi = 10;
    public int UzakPalet4UrunTutmaSayisi = 10;
    [Header("Musteriler")]
    public float MusteriGelmeSuresi = 7.5f;
    public float MusteriAracizi = 0.2f;
    [Header("KancaOtomasyonSistemi")]
    public float KancaDelay = 10f;
    public float KancaHizi = 0.02f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetDefault()
    {
        PlayerPrefs.SetInt(nameof(urunKalitesi), 10);
        //[Header("Üretim cihazları")]
        PlayerPrefs.SetFloat(nameof(TierBirUretimBandiDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierIkiUretimBandiDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierUcUretimBandiDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierDortUretimBandiDelayi), 8);

        PlayerPrefs.SetFloat(nameof(TierBirYanUretimBandıDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierIkiYanUretimBandıDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierUcYanUretimBandıDelayi), 8);
        PlayerPrefs.SetFloat(nameof(TierDortYanUretimBandıDelayi), 8);
        
        PlayerPrefs.SetInt(nameof(TierBirUrunTutmaSayısı), 10);
        PlayerPrefs.SetInt(nameof(TierIkiUrunTutmaSayısı), 10);
        PlayerPrefs.SetInt(nameof(TierUcUrunTutmaSayısı), 10);
        PlayerPrefs.SetInt(nameof(TierDortUrunTutmaSayısı), 10);

        PlayerPrefs.SetFloat(nameof(kutularinHizi), 0.04f);
        
        //[Header("Paletler")]
        PlayerPrefs.SetInt(nameof(Palet1UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(Palet2UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(Palet3UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(Palet4UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(Palet5UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(Palet6UrunTutmaSayisi), 10);

        //[Header("UzakPaletler")]
        PlayerPrefs.SetInt(nameof(UzakPalet1UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(UzakPalet2UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(UzakPalet3UrunTutmaSayisi), 10);
        PlayerPrefs.SetInt(nameof(UzakPalet4UrunTutmaSayisi), 10);
       
        //[Header("Musteriler")]
        PlayerPrefs.SetFloat(nameof(MusteriGelmeSuresi), 7.5f);
        PlayerPrefs.SetFloat(nameof(MusteriAracizi), 0.2f);
        //[Header("KancaOtomasyonSistemi")]
        PlayerPrefs.SetFloat(nameof(KancaDelay), 10f);
        PlayerPrefs.SetFloat(nameof(KancaHizi), 0.02f);
    }
}
