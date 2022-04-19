using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocUltimate : MonoBehaviour
{

    public float healAmount = 300f;

    public float radius = 15f;

    public float ultCD = 30f;

    public ParticleSystem ultimateEffect;

    public Text ultCDText;

    public bool ulted;

    private float currentUltCD;
















    // Start is called before the first frame update
    void Start()
    {
        currentUltCD = ultCD;
        ultCDText.text = ultCD.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ultCDText.text = currentUltCD.ToString("0");
        Debug.Log(currentUltCD);
        NanoBurstCD();

    }


    void NanoBurstCD()
    {

    }
}
