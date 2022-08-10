using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public string Tier = "1";
    public float speed = 0.4f;
    public bool turnBackBitch = false;
    public float DestroyTime = 6f;
    public float waitTime = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Tier == "1")
        {
            if (transform.position.x > 31 && !turnBackBitch)
            {
                transform.position += Vector3.right * -speed;
            }
            else
            {

                if (waitTime > 5f)
                {
                    turnBackBitch = true;
                    transform.position += Vector3.right * speed;
                    Destroy(this.gameObject, DestroyTime);
                }
                else
                {
                    waitTime += Time.deltaTime * 1;
                }
            }
        }
        else if (Tier == "2")
        {
            if (transform.position.x > -70 && !turnBackBitch)
            {
                transform.position += Vector3.right * -speed;
            }
            else
            {

                if (waitTime > 5f)
                {
                    turnBackBitch = true;
                    transform.position += Vector3.right * speed;
                    Destroy(this.gameObject, DestroyTime-1);
                }
                else
                {
                    waitTime += Time.deltaTime * 1;
                }
            }
        }

    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5f);
        turnBackBitch = true;
    }
}
