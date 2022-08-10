using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    public float araçHizi = 100f;
    public float urunToplamaVeVermeHizi = 1f;    
    public int maxItemTutmaSayisi = 3;
    


    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetDefault()
    {
        PlayerPrefs.SetFloat(nameof(araçHizi),5f);
        PlayerPrefs.SetFloat(nameof(urunToplamaVeVermeHizi),1f);
        PlayerPrefs.SetInt(nameof(maxItemTutmaSayisi),3);
    }

}
