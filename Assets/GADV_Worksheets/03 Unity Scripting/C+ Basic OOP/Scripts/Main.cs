using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class projectile
{
    private float speed = 1.0f;
    public projectile()
    {
        speed = 2.0f;
    }
    public void AutoFire()
    {
        speed = 100.0f;
        Debug.Log("Speed was Zero,set to 100 and launched");
    }
    public void fire()
    {
        if (speed > 0) {
            Debug.Log($"Firing Projectile at speed {speed}");
        }
        else
        {
            AutoFire();
        }
    }
};