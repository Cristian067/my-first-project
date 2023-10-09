using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{


    [SerializeField] private float num1;
    [SerializeField] private float num2;
    private float num3;
    [SerializeField] private int numEntero;
    private int result;

    [SerializeField] private int num;


    // Start is called before the first frame update
    void Start()
    {
        /*
        num3 = num1 + num2;
        Debug.Log($"{ num1} + { num2} = " + num3);

        num3 = num1 - num2;
        Debug.Log($"{num1} - {num2} = " + num3);

        num3 = num1 * num2;
        Debug.Log($"{num1} * {num2} = " + num3);

        num3 = num1 / num2;
        Debug.Log($"{num1} / {num2} = " + num3);
        */
        //numero D.
        Debug.Log(numEntero % 9);


        num3 = num % 2;

        Debug.Log(num3);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
