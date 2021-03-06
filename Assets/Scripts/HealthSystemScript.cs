﻿using UnityEngine;
using System.Collections;

public class HealthSystemScript : MonoBehaviour {
    public float totalHealth = 100f;
    public float currentHealth;

    public GameObject Audio_hurt;
	// Use this for initialization
	void Start () {
        currentHealth = totalHealth;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SubtractHealth(float amount)
    {
        if (currentHealth - amount <= 0f)
        {
            TriggerGameOver();
        }
        Audio_hurt.audio.Play();
        currentHealth -= amount;
        
    }

    public void AddHealth(float amount)
    {
        currentHealth += amount;
        if (currentHealth + amount >= totalHealth)
        {
            currentHealth = totalHealth;
        }
    }
    void TriggerGameOver()
    {
        gameObject.GetComponent<ShoeController>().gameState = ShoeController.GameStates.end;
    }
}
