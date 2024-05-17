using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    private int maxHealth = 3;
    private int minHealth = 1;
    private int takeDamageReleaseTime = 1;

    public BatteryController batteryController;
    public GameObject Spawn;
    public GameObject Gizmo;
    public GameObject[] gears;
    public int health;

    public bool isTakingDamage = false;

    void Awake()
    {
        health = maxHealth;
    }

    void UpdateHealth()
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

    public bool TakeDamage()
    {
        isTakingDamage = true;
        Invoke("releaseTakeDamage", takeDamageReleaseTime);
        if (health == minHealth)
        {
            Respawn();
            return false;
        }
        else
        {
            health -= 1;
            UpdateHealth();
            return true;
        }
    }

    public void Heal()
    {
        if (health != maxHealth)
        {
            health += 1;
            UpdateHealth();
        }
    }

    private void releaseTakeDamage()
    {
        isTakingDamage = false;
    }

    public void Respawn()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
