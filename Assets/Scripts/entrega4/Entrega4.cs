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

    [SerializeField] private int tBase;
    [SerializeField] private int tHeight;

    [SerializeField] private int note;

    [SerializeField] private int num3;


    private int actYear = System.DateTime.Now.Year;





    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(moreOrLower(num1, num2));

        Debug.Log(vowel(letter));

        Debug.Log(validDate(day, month, year, actYear));

        Debug.Log(biYear(year));

        oneMoreDay(day,month,year);
        oneLessDay(day,month,year);

        Debug.Log(chino(year));

        Debug.Log(tArea(tBase, tHeight));

        Debug.Log(grade(note));

        Debug.Log(isEven(num3));

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


    //ej.4

    private string biYear(int year)
    {
        bool boolBi = (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        string bi ="";

        if (boolBi)
        {
            bi = $"El año {year} es bisiesto";
        }
        else
        {
            bi = $"El año {year} no es bisiesto";
        }
        return bi;
    }

    //ej.5

    private void oneMoreDay(int day, int month, int year)
    {
        day ++;

        if(month == 2 && day > 28)
        {
            month ++;
            day = day - 28;
        }

        if (day > 30 && (month == 4 || month == 6 || month == 9 || month == 11))
        {
            day = day - 30;
            month++;
        }
        else if (day > 31)
        {
            day = day - 31;
            month++;
        }
        if (month > 12)
        {
            month = month - 12;
            year++;
        }
        Debug.Log($"La fecha con un dia mas es {day}/{month}/{year}");
    }

    //ej.6
    private void oneLessDay(int day, int month, int year)
    {
        day--;

        if (month == 2 && day > 28)
        {
            month++;
            day = day - 28;
        }

        if (day > 31)
        {
            day = day - 31;
            month++;
        }
        if (month > 12)
        {
            month = month - 12;
            year++;
        }

        if (month == 3 && day < 1)
        {
            month++;
            day = day + 28;
        }

        if (day < 1)
        {
            day = day + 31;
            month--;
        }
        if (month < 1)
        {
            month = month + 12;
            year--;
        }
        Debug.Log($"La fecha con un dia menos es {day}/{month}/{year}");
    }

    //ej.7

    private string chino(int year)
    {
        string[] xino = new string[12];
        xino[0] = "Rata";
        xino[1] = "Buey";
        xino[2] = "Tigre";
        xino[3] = "Conejo";
        xino[4] = "Dragon";
        xino[5] = "Serpiente";
        xino[6] = "Caballo";
        xino[7] = "Cabra";
        xino[8] = "Mono";
        xino[9] = "Gallo";
        xino[10] = "Perro";
        xino[11] = "Cerdo";


        int animal = year % 12 - 4;

        string result = $"El año chino del año {year} es {xino[animal]}";

        return result ;
    }

    //ej.8

    private int tArea(int tBase, int tHeight)
    {

        int area = 0;
        if (tBase >= 1 && tHeight >= 1)
        {

        area = (tBase * tHeight) / 2;
        }
        return area;

    }

    //ej.9

    private string grade(int note)
    {
        string result = "";
        if(note < 5)
        {
            result = "D"; 
        }
        else if(note >= 5 && note < 7)
        {
            result = "C";
        }
        else if(note >= 7 && note < 9)
        {
            result = "B";
        }
        else if(note >= 9)
        {
            result = "A";
        }

        return result ;

    }


    //ej.10
    private bool isEven(int num)
    {
        bool result = false;

        int Even = 0;

        Even = num % 2;

        if(Even == 0)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        return result;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
