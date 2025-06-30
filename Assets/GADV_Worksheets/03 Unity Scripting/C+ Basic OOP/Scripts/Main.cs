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
public class ScoreTracker
{
    private int score;

    private void ResetScore()
    {
        score = 0;
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
public class player
{
    private int health = 100;
    private void TakeDamage(int amount)
    {
        health -= amount;
    }
    private void GetHealth(int amount)
    {
        health += amount;
    }
    public void startinghealth()
    {
        health = 50;
    }
};

public class TreasureChest { 
    public void AncientChest()
    {

    }
};