using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosStatusController : MonoBehaviour
{
    private int maxHealth = 3;
    private int minHealth = 1;

    public HealthController healthController;

    public int health = 3;
    public int battery = 3;

    void Awake()
    {
        healthController.UpdateHealth(maxHealth);
    }

    void Update()
    {

    }

    public void TakeDamage()
    {
        if (health == minHealth)
        {
            Die();
        }
        else
        {
            health -= 1;
            healthController.UpdateHealth(health);
        }
    }

    public void Heal()
    {
        if (health != maxHealth)
        {
            health += 1;
            healthController.UpdateHealth(health);
        }
    }

    public void Die()
    {

    }

}
