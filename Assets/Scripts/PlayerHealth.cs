using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 200f;

    public float currentHealth;

    public float healthRegen = .05f;

    public HealthBarScript healthBar;

    public Text hpText;
 
    private void Start()
    {
        currentHealth = maxHealth; // Sets the current health to equal the max health 
        healthBar.SetMaxHealth(maxHealth);
        hpText.text = maxHealth.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // For testing purpose of taking damage 
        {
            TakeDamage(20);
        }

        HealthRegenerate();

        Debug.Log(currentHealth);

        hpText.text = currentHealth.ToString("0");
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        
    }

    
    void HealthRegenerate() // When HP drops below maxHealth health will begin to regenerate
    {
        if(currentHealth < maxHealth)
        {
            StartCoroutine(HealthRegen());
            Debug.Log("Health Regenerate Coroutine started");
        }
        else if(currentHealth >= maxHealth)
        {
            StopCoroutine(HealthRegen());
            Debug.Log("Health Regenerate Coroutine stopped");
        }
    }

    IEnumerator HealthRegen()
    {
        Debug.Log("Health should be Regenerating");
        
        yield return new WaitForSeconds(2);

        while(currentHealth < maxHealth)
        {
            currentHealth += healthRegen;
            healthBar.SetHealth(currentHealth);
            yield return new WaitForSeconds(.01f); // RegenTick
        }
    }
}
