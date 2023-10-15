using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class entrega_2_2 : MonoBehaviour
{
    //ej.1
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    //ej.4
    private string moreOrLess;
    //ej.5
    [SerializeField] private string nombre;

    //ej.7
    [SerializeField] private int molNum1;
    [SerializeField] private int molNum2;

    // Start is called before the first frame update
    void Start()
    {

        //ej. 2

        Debug.Log(num1 + num2);
        
        //ej.3
        if (num1 > num2)
        {
            moreOrLess = "El primer numero es mas alto";
            Debug.Log(moreOrLess);
        }
        else if (num2 > num1)
        {
            moreOrLess = "El segundo numero es mas alto";
            Debug.Log(moreOrLess);
        }
        else
        {
            moreOrLess = "Los dos numeros son iguales";
            Debug.Log(moreOrLess);
        }

        //ej.6
        Debug.Log($"Welcome {nombre}");

        //ej.8
        Debug.Log(molNum1 %molNum2);

        //ej.9
        Debug.Log($"Hello! My name is {nombre}");
        



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
