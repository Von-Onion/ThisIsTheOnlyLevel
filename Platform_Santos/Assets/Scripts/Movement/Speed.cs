using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Speed : MonoBehaviour
{
    private float basicSpeed = 5f;
    [SerializeField] private float currentSpeed = 5f;
    [SerializeField] private float maxSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {

        Console.WriteLine(SetSpeed());
    }

    private float SetSpeed()
    {
        SpeedMultiplier(1.5f);
        SpeedBuffTimer(3);
        SetMaxSpeed();
        return currentSpeed;
    }

    private float SpeedMultiplier(float multiplier)
    {
        multiplier = 1;
        currentSpeed *= multiplier;
        return currentSpeed;
    }

    private float SpeedBuffTimer(float seconds)
    {
        seconds -= Time.deltaTime;
        if(seconds == 0)
        {
            currentSpeed = basicSpeed;
        }
        return currentSpeed;
    }

    private float SetMaxSpeed()
    {
        if(currentSpeed > maxSpeed)
        {
            return maxSpeed;
        }
        else
        {
             return currentSpeed;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
