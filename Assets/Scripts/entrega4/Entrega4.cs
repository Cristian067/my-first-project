using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega4 : MonoBehaviour
{

    [SerializeField] private float num1;
    [SerializeField] private float num2;

    [SerializeField] private string letter;

    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    private int actYear = System.DateTime.Now.Year;





    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(moreOrLower(num1, num2));

        Debug.Log(vowel(letter));

        Debug.Log(validDate(day, month, year, actYear)); 

    }

    //ej.1
    private string moreOrLower(float num1, float num2)
    {

        string masomenos;

        if (num1 > num2)
        {
            masomenos = $"El primer numero es mayor que el segundo";
        }
        else if (num1 < num2)
        {
            masomenos = $"El segundo numero es mayor que el primero";
        }
        else
        {
            masomenos = "los numeros son iguales";
        }

        return masomenos;

    }

    //ej.2

    private bool vowel(string letter)
    {
        bool vocal;

        if (letter == "a"||letter=="e"||letter=="i"||letter=="o"||letter=="u")
        {
            vocal = true;
        }
        else
        {
            vocal = false;
        }

        return vocal;

    }

    //ej.3

    private bool validDate(int day, int month, int year, int actYear)
    {
        bool valid;
        if (day > 31 || month > 12 || year > actYear)
        {
            valid = false;
        }
        else
        {
            valid = true;
        }

        return valid;
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
