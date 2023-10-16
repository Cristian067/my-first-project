using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Entrega_3 : MonoBehaviour
{


    [SerializeField] private float num1;
    [SerializeField] private float num2;

    [SerializeField] private string letra;

    [SerializeField] private int dNum1;
    [SerializeField] private int dNum2;

    [SerializeField] private int grade;

    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;


    [SerializeField] private string week;

    [SerializeField] private int age;
    [SerializeField] private string rank;




    // Start is called before the first frame update
    void Start()
    {
        //ej.1

        if (num1 > num2)
        {
            Debug.Log($"El primer numero es mas grande ({num1})");
        }
        else if (num1 < num2)
        {
            Debug.Log($"El segundo numero es mas grande ({num2})");
        }

        //ej.2
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log("Es una vocal");
        }
        else
        {
            Debug.Log("Es una consonante");
        }

        //ej.3
        if (dNum1 / dNum2 == 0)
        {
            Debug.Log($"{dNum1} y {dNum2} son divisibles entre si");
        }
        else
        {
            Debug.Log("no son diisibles");
        }

        //ej.4

        if (grade >= 9)
        {
            Debug.Log("A = Excelente");
        }
        else if (grade >= 7)
        {
            Debug.Log("B = Notable");
        }
        else if (grade >= 5)
        {
            Debug.Log("C = aprobado");
        }
        
        else if (grade < 5)
        {
            Debug.Log("D = suspendido");
        }

        //ej.5

        if (day <=30 && month <= 12 && year > 0)
        {
            Debug.Log($"La fecha {day}/{month}/{year} es valida");
        }
        else
        {
            Debug.Log($"La fecha {day}/{month}/{year} no es valida");
        }

        //ej.8

        if (week == "sabado" || week == "domingo")
        {
            Debug.Log("Es fin de semana");
        }
        else
        {
            Debug.Log("Es entre semana");
        }

        //ej.9

        if (age >= 65 && rank == "gold")
        {
            Debug.Log("75% de descuento");
        }
        else if(age >=65 && rank == "silver")
        {
            Debug.Log("50% de descuento");
        }
        else if (age >=65 && rank == "bronze")
        {
            Debug.Log("25% de descuento");
        }
        else if (age < 18)
        {
            Debug.Log("No tienes descuento");
        }
        else if (age < 65 && rank == "gold")
        {
            Debug.Log("50% de descuento");
        }
        else if (age < 65 && rank == "silver")
        {
            Debug.Log("25% de descuento");
        }
        else if (age < 65 && rank == "bronze")
        {
            Debug.Log("15% de descuento");
        }
        













    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
