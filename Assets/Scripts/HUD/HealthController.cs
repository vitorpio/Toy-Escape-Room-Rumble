using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public GameObject[] gears;

    public void UpdateHealth(int health)
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
}
