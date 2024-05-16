using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private int maxHealth = 3;
    private int minHealth = 1;
    private int takeDamageReleaseTime = 1;

    public GameObject[] gears;
    public int health = 3;

    public bool isTakingDamage = false;

    void UpdateHealth(int health)
    {
        for (int i = 0; i < gears.Length; i++)
        {
            if (i < health)
            {
                gears[i].SetActive(true);
            }
            else
            {
                gears[i].SetActive(false);
            }
        }
    }

    public void TakeDamage()
    {
        if (health == minHealth)
        {

        }
        else
        {
            isTakingDamage = true;
            health -= 1;
            UpdateHealth(health);
            Invoke("releaseTakeDamage", takeDamageReleaseTime);
        }
    }

    public void Heal()
    {
        if (health != maxHealth)
        {
            health += 1;
            UpdateHealth(health);
        }
    }

    private void releaseTakeDamage()
    {
        isTakingDamage = false;
    }
}
