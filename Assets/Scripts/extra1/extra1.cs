using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra1 : MonoBehaviour
{


    [SerializeField] private int num;
    [SerializeField] private int nota;

    [SerializeField] private int ladoT_1;
    [SerializeField] private int ladoT_2;
    [SerializeField] private int ladoT_3;

    [SerializeField] private string letra;

    [SerializeField] private int dia;
    [SerializeField] private int mes;
    [SerializeField] private int anio;

    private int contenedorFecha;
    
    
    

    private int descuento;


    // Start is called before the first frame update
    void Start()
    {

        //ej.1
        
        if (num > 0) {

            Debug.Log("El numero es positivo");  
         };

        //ej.2
        if (num < 0) {

            Debug.Log("El numero es negativo");
        };


        //ej.3

        if (num > 0)
        {
            Debug.Log("El numero es positivo");
        }
        else if (num < 0)
        {
            Debug.Log("El numero es negativo");
        }
        else if (num == 0)
        {
            Debug.Log("el numero es 0");
        };


        //ej.4

        if (nota < 5)
        {
            Debug.Log("Suspenso");
        }
        else if(nota >= 5 && nota < 7)
        {
            Debug.Log("Aprobado");
        }
        else if(nota >= 7 && nota < 9)
        {
            Debug.Log("Notable");
        }
        else if(nota >= 9)
        {
            Debug.Log("Excelente");
        };


        //ej.5

        descuento = 100 - 90%100;


        Debug.Log(100 - descuento);

        //ej.6

        if(ladoT_1 == ladoT_2 && ladoT_1 == ladoT_3 && ladoT_2 == ladoT_3)
        {
            Debug.Log("Equilatero (3iguales)");
        }
        else if(ladoT_1 == ladoT_2 && ladoT_1 != ladoT_3 && ladoT_2 != ladoT_3)
        {
            Debug.Log("isosceles (dos igueles)");
        }
        else if (ladoT_1 != ladoT_2 && ladoT_1 == ladoT_3 && ladoT_2 != ladoT_3)
        {
            Debug.Log("isosceles (dos igueles)");
        }
        else if (ladoT_1 != ladoT_2 && ladoT_1 != ladoT_3 && ladoT_2 == ladoT_3)
        {
            Debug.Log("isosceles (dos igueles)");
        }
        else
        {
            Debug.Log("Escaleno (ninugno igual)");
        };

        /* ej.9:
        
        //ej.7

        if (letra == "a" | letra == "e" | letra == "i" | letra == "o" | letra =="u")
        {
            Debug.Log("es una vocal");
        }
        //ej.8
        else
        {
            Debug.Log("Es una consonante");
        };
        */

        //ej.10

        contenedorFecha = dia + (30 * mes);

        Debug.Log($"han pasado {contenedorFecha} dias");

        //ej.11

        bool boolBi = (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0); 


        if (boolBi)
        {
            Debug.Log($"El año {anio} es bisiesto");
        }
        /*

        Debug.Log(boolBi);
        Debug.Log(anio % 4);
        Debug.Log(anio % 400);
        Debug.Log("100" + anio % 100 );
        */



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
