using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocHeal : MonoBehaviour
{
    public Camera fpsCamera;

    public float healAmount = 50f;

    public float range = 20f;

    public float healCooldown = 8f;

    // public ParticleSystem healEffect;

    public float healThickness = 2f;

    public Text cooldownText;

    public bool healed;

    private float currentHealCooldown;

    // Start is called before the first frame update
    void Start()
    {
        
        currentHealCooldown = healCooldown;
        cooldownText.text = healCooldown.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownText.text = currentHealCooldown.ToString("0");
        Debug.Log(currentHealCooldown);
        NanoHealthCooldown();
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentHealCooldown == healCooldown) 
            {
                Heal();
            }
            else if (currentHealCooldown != healCooldown) //Wont activate since cooldown timer is not 8 
            {
                Debug.Log("Cannot heal. Ability on cooldown");
            }
            
            
        }
    }



    void Heal()
    {

        RaycastHit hit;
        if (Physics.SphereCast(fpsCamera.transform.position, healThickness, fpsCamera.transform.forward, out hit, range)) // Using sphere cast for easier hit detection for healing
        //              Shoots from camera position,   shoots forward from camera,   checks for if in range.
        {
            Debug.Log(hit.transform.name);

            Ally ally = hit.transform.GetComponent<Ally>();

            

            if (ally != null) // If object healed has no ally component does nothing 
            {
                ally.currentHealth += healAmount;
                NanoHealthCooldown();
                ally.docHeal.Play();
                healed = true;
            }

            

        }
    }

    void NanoHealthCooldown()
    {
        if (healed == true && currentHealCooldown >=0) // Reduces nano heal cooldown timer as long as the timer is not 0
        {
            currentHealCooldown -= 1f * Time.deltaTime;
        }
        else if (currentHealCooldown < 0) // Once timer is less then 0 cooldown resets  
        {
            healed = false;
            currentHealCooldown = healCooldown;
        }
    }

   

}
