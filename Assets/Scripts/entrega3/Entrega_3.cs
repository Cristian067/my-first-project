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

    [SerializeField] private string[] chino = new string[12];

    [SerializeField] private string[] horoscopo = new string[12];

    [SerializeField] private int t1;
    [SerializeField] private int t2;
    [SerializeField] private int t3;

    private int numhorosc;

    private int animal;




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

        //ej.6



        //Debug.Log(2020 % 12 - 4);
        animal = year % 12 - 4;

        Debug.Log($"El a�o chino del a�o {year} es {chino[animal]}");


        //ej.7

        


        if(month == 3 && day >= 21 || month == 4 && day <= 19)
        {
            numhorosc = 0;
            
        }
        
        else if (month == 4 && day >= 20 || month == 5 && day <= 20)
        {
            numhorosc = 1;
        }
        else if (month == 5 && day >= 21 || month == 6 && day <= 20)
        {
            numhorosc = 2;
        }
        else if (month == 6 && day >= 21 || month == 7 && day <= 22)
        {
            numhorosc = 3;
        }
        else if (month == 7 && day >= 23 || month == 8 && day <= 22)
        {
            numhorosc = 4;
        }
        else if (month == 8 && day >= 23 || month == 9 && day <= 22)
        {
            numhorosc = 5;
        }
        else if (month == 9 && day >= 23 || month == 10 && day <= 22)
        {
            numhorosc = 6;
        }
        else if (month == 10 && day >= 23 || month == 11 && day <= 22)
        {
            numhorosc = 7;
        }
        else if (month == 11 && day >= 23 || month == 12 && day <= 21)
        {
            numhorosc = 8;
        }
        else if (month == 12 && day >= 22 || month == 1 && day <= 19)
        {
            numhorosc = 9;
        }
        else if (month == 1 && day >= 20 || month == 2 && day <= 18)
        {
            numhorosc = 10;
        }
        else if (month == 2 && day >= 19 ||  month == 3 && day <= 20)
        {
            numhorosc = 11;
        }


        Debug.Log(horoscopo[numhorosc]);


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
        


        //ej.10
        if(t1 + t2 + t3 == 180)
        {
            Debug.Log($"Los angulos {t1}, {t2} y {t3} pueden formar un triangulo");
        }
        else
        {
            Debug.Log($"Los angulos {t1}, {t2} y {t3} no pueden formar un triangulo");
        }

        

        








    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
