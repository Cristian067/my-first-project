using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra1_2 : MonoBehaviour
{

    [SerializeField] private int dia;
    [SerializeField] private int mes;
    private int tDias = 30;
    private int tMes = 12;

    
    [SerializeField] private int alt;
    [SerializeField] private int anch;


    [SerializeField] private int actYear;
    [SerializeField] private int nacYear;

    //ej.16
    private int[] numeros = new int[5];

    //ej.17
    private string[] strings = new string[10];
    
    //ej.18
    private float[] floats = new float[3];

    //ej.19
    [SerializeField] private string[] vocals = new string[5];
    


    // Start is called before the first frame update
    void Start()
    {
        //ej.10
        Debug.Log("Han pasado " + (dia + (mes * 30)) + " dias");


        //ej.13

        Debug.Log((alt + anch) / 2);


        //ej.14

        Debug.Log(-(nacYear - actYear)+ " años");

        //ej.15


        //ej.16
        /*
        numeros = new int[5];
*/
        numeros[0] = 1;
        numeros[1] = 2;
        numeros[2] = 3;
        numeros[3] = 4;
        numeros[4] = 5;

        //ej.20
        Debug.Log(numeros[0]);

        //ej.21
        Debug.Log(strings[0]);

        //ej.22
        floats[1] = 1.5f;

        //ej.23
        Debug.Log(vocals[3]);

        //ej.24
        Debug.Log(strings.Length);

        //ej.25
        Debug.Log(numeros[0] + numeros[4]);



    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
