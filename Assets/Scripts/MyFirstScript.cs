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



}
