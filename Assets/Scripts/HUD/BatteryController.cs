using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryController : MonoBehaviour
{
    private Image image;
    private int maxBattery = 3;
    private int minBattery = 0;
    private int batteryReduceTime = 5;
    private IEnumerator coroutine;

    public int currentBattery;
    public List<Sprite> batterySprites;


    void Awake()
    {
        image = GetComponent<Image>();

        RechargeFull();
    }

    public void Recharge()
    {
        if (currentBattery < maxBattery)
        {
            currentBattery += 1;
            image.sprite = batterySprites[currentBattery];
        }
        StartBatteryReduce();
    }

    public void RechargeFull()
    {
        currentBattery = maxBattery;
        image.sprite = batterySprites[currentBattery];
        StartBatteryReduce();
    }

    void StartBatteryReduce()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = ReduceBattery();
        StartCoroutine(coroutine);
    }

    IEnumerator ReduceBattery()
    {
        yield return new WaitForSeconds(batteryReduceTime);
        currentBattery--;
        if (currentBattery < 0)
        {
            // gizmosStatusController.Die();
        }
        else
        {
            image.sprite = batterySprites[currentBattery];
            StartBatteryReduce();
        }
    }
}
