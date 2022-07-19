using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public GameManager gm;
    public Text moneyText;




    private void Update() {
        MoneyUIUpdate();
    }




    void MoneyUIUpdate()
    {
        moneyText.text = "= "+gm.money.ToString();
    }
}
