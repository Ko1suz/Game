using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookAndRope : MonoBehaviour
{
    public string Blok = "1";
    public string Tier = "1";

    UpgradeStats upgradeStats;

    private void Start()
    {
        upgradeStats = UpgradeStats.instance;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Blok == "1")
        {
            if (transform.position.z <= -11.5f && Tier == "1")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -39.004)
                {
                    Destroy(this.gameObject);
                }
            }
            else if (transform.position.z <= -11f && Tier == "2")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -39.004)
                {
                    Destroy(this.gameObject);
                }
            }
            else if (transform.position.z <= -12.0f && Tier == "3")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -39.004)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                transform.position -= new Vector3(0, 0, upgradeStats.KancaHizi);
            }
        }
        else if (Blok == "2")
        {
            if (transform.position.z <= -11.5f && Tier == "1")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -164.24f)
                {
                    Destroy(this.gameObject);
                }
            }
            else if (transform.position.z <= -11f && Tier == "2")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -164.24f)
                {
                    Destroy(this.gameObject);
                }
            }
            else if (transform.position.z <= -12.0f && Tier == "3")
            {
                transform.position -= new Vector3(upgradeStats.KancaHizi, 0, 0);
                if (transform.position.x <= -164.24f)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                transform.position -= new Vector3(0, 0, upgradeStats.KancaHizi);
            }
        }


    }
}
