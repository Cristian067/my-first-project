using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Animal : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    
    [SerializeField] private int legs = 4;
    [SerializeField] private string aName = "";

    private void Start()
    {
        Debug.Log(name + "." + aName + "." + legs);
        Debug.Log($"El {aName} tiene {legs} patas");
        
    }





}
