using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocUltimate : MonoBehaviour
{
    public Transform DocPos;



    public float healAmount = 300f;

    public float ultRadius = 15f;

    public float ultCD = 30f;

    public ParticleSystem ultimateEffect;

    public Text ultCDText;

    public bool ulted;

    private float currentUltCD;


    [SerializeField] private LayerMask AlliesInRange; //Allies in allies layer will be healed my Doc Ult



    private PlayerHealth playerHealth;









    // Start is called before the first frame update
    void Start()
    {
        currentUltCD = ultCD;
        ultCDText.text = ultCD.ToString();

        playerHealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        ultCDText.text = currentUltCD.ToString("0");
        Debug.Log(currentUltCD);
        NanoBurstCD();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(currentUltCD == ultCD)
            {
                Debug.Log("nanoburst activated");
                ActivateNanoBurst();
                ultimateEffect.Play();
                ulted = true;
            }
        }

    }

    void ActivateNanoBurst()
    {

        playerHealth.currentHealth += healAmount;

        Collider[] hitColliders = (Physics.OverlapSphere(DocPos.position, ultRadius, AlliesInRange));
        foreach (var hitCollider in hitColliders)
        {
            Ally ally = hitCollider.transform.GetComponent<Ally>();

            if(ally != null) // If object healed has no ally component does nothing 
            {
                ally.currentHealth += healAmount;
                NanoBurstCD();
                ally.docHeal.Play();
            }
        }
    }
    void NanoBurstCD()
    {
        if (ulted == true && currentUltCD >= 0) // Reduces nano heal cooldown timer as long as the timer is not 0
        {
            currentUltCD -= 1f * Time.deltaTime;
        }
        else if (currentUltCD < 0) // Once timer is less then 0 cooldown resets  
        {
            ulted = false;
            currentUltCD = ultCD;
        }
    }
}
