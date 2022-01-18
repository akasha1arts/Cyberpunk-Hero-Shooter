using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Heroes", menuName = "Hero")]
public class Test : ScriptableObject 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FizzBuzzMethod();
    }


    void FizzBuzzMethod()
    {
        for (int i = 1; i <= 100; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Fizz Buzz");
            }
            else if(i % 3 == 0)
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
}
