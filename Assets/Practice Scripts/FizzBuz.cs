using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuz : MonoBehaviour
{
    Vector3 myVector; // Declaring Vector

    int[] Nums = { 12, 121, 1585, 16811 }; // Declaring Array

    int correctCode = 3;

    // Start is called before the first frame update
    void Start()
    {
        

        myVector = new Vector3(1f, 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Fizzbuzz();
        StartCoroutine(Debuff());

    }

    void Fizzbuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Fizz Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    IEnumerator Debuff()
    {
        for (float debuff = 3f; debuff <= 5f; debuff -= 1f)
        {
            yield return new WaitForSeconds(3f); // Or can just make yeild return null; if no need to wait


           
        }
    }


    void CodeCheck()
    {
        switch (correctCode)
        {
            case 3:

                break;
            case 2:

                break;
            case 1:

                break;

            default:

                break;
        }
    }

    // Unity Execution Order

    /* Awake, Start, FixedUpdate, Update, OnApplicationQuit */
}
