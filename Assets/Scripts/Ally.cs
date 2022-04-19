using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public float maxHealth = 200f;

    public float currentHealth;

    public HealthBarScript healthBar;

    public ParticleSystem docHeal;

    private bool healedByDoc = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Sets the current health to equal the max health 
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // For testing purpose of taking damage 
        {
            TakeDamage(20);
        }

        healthBar.SetHealth(currentHealth);


    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);


    }

    
}
