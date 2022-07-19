using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public string type = "KartonKutu";
    public bool isAlredyCollected = false;
    public bool isAlredyCollectedPalet = false;
    public float speed;
    public bool yonunu180DereceDegistir;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (isAlredyCollectedPalet)
        {
            return;
        }
        else if (other.CompareTag("UretimPaleti"))
        {
            Collector collector;
            if (other.TryGetComponent(out collector) && collector.numOfItemsHolding <= collector.maxItemHold)
            {
                collector.AddNewItem(this.transform);
                isAlredyCollectedPalet = true;
                this.speed = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        Move();
    }


    protected void Move()
    {
        if (isAlredyCollected == false && !yonunu180DereceDegistir)
        {
            transform.position += Vector3.right * -speed;
        }
        else if (isAlredyCollected == false && yonunu180DereceDegistir)
        {
            transform.position += Vector3.left * -speed;
        }
    }
}
