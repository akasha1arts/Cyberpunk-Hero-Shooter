using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2 : MonoBehaviour
{

    float debuff; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FizzBuzz();
        StartCoroutine(Debuff());
    }

    void FizzBuzz()
    {
        for (int i = 5; i <= 40; i++)
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
                Debug.Log("Buzz" + i);
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    IEnumerator Debuff()
    {
        for (float debuff = 3f; debuff <= 0f; debuff -= 1f)
        {

        }



        yield return null; 
    }
}
