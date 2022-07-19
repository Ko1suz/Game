using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMoneyCollector : MonoBehaviour
{
    public GameManager gm;
    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }
    public void CollectMoney(Transform _itemToAdd)
    {
        
        _itemToAdd.DOJump(transform.position , 1f, 2, .3f).OnComplete(
            () =>
            {
                _itemToAdd.SetParent(this.transform, true);
                _itemToAdd.position = transform.position;
                _itemToAdd.localRotation = Quaternion.identity;
                //TODO para için particle effect çıksın
                gm.moneyParticles.transform.position = this.gameObject.transform.position+ new Vector3(0,1.75f,0);
                gm.moneyParticles.Play();
                gm.AddMoney();
                Destroy(_itemToAdd.gameObject);
            }

        );
    }
}
