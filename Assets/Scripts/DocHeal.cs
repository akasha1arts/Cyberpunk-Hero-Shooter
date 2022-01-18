using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocHeal : MonoBehaviour
{
    public Camera fpsCamera;

    public float healAmount = 50f;

    public float range = 15f;

    public float healCooldown = 8f;

    public ParticleSystem healEffect;

    public float healThickness = 2f;

    public Text cooldownText;

    private bool healed;

    private float currentCooldown;

    // Start is called before the first frame update
    void Start()
    {
        healed = false;
        currentCooldown = healCooldown;
        cooldownText.text = healCooldown.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
       

        if (Input.GetKeyDown(KeyCode.E))
        {
            Heal();
           cooldownText.text = currentCooldown.ToString("0");
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
                healed = true;
            }

            healEffect.Play();

        }
    }

    void NanoHealthCooldown()
    {
        if (healed == true)
        {
            healCooldown -= .05f * Time.deltaTime;
        }
    }

}
