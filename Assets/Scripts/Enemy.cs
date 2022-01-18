using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;

   

    public HealthBarScript healthBar;

    private void Start()
    {
       
        healthBar.SetMaxHealth(health);
    }


    private void Update()
    {
        healthBar.SetHealth(health);
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
