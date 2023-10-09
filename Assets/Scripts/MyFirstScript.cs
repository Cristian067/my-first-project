using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyFirstScript : MonoBehaviour
{
    //variablo con numero entero
    [SerializeField]  private int age = 18;

    //variable numero con decimal
    [SerializeField]  private float speed = 3.13f;

    //variable verdadero o falso
    [SerializeField]  private bool isDead = false;

    //variable con caracteres
    [SerializeField]  private string nick = "Juan";

    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private float coins;

    private float num3;
    private float result;

    [SerializeField] private int hour;


    private void Start()
    {
        /*
        Debug.Log("Hola, mundo");
        Debug.Log(age);
        Debug.Log(speed);
        Debug.Log(isDead);
        Debug.Log(nick);
        Debug.Log($"nombre de usuario: {nick}");
        Debug.Log("Edad: " + age);
        Debug.Log(string.Format("La velocidad es {0} m/s", speed));
        *//*
        
        
        while(num3 >= 10) { }
        *//*
        num3 = num1 + num2;
        Debug.Log(num3);
        Debug.Log($"Monedas: {coins}");
        //coins = coins + 10;
        coins += 10;
        Debug.Log($"Monedas: {coins}");
        *//*

        Debug.Log($"{num1} + {num2} = {num1 + num2}");
        Debug.Log($"{num1} - {num2} = {num1 - num2}");
        Debug.Log($"{num1} * {num2} = {num1 * num2}");
        Debug.Log($"{num1} / {num2} = {num1 / num2}");

        *//*
        coins = coins + 5;
        coins += 5;
        coins++;
        
        coins = coins - 5;
        coins -= 5;
        coins--;
        
        coins = coins * 5;
        coins *= 5;

        coins = coins / 5;
        coins /= 5;
        */




        Debug.Log(hour % 9);
        




    }


}
