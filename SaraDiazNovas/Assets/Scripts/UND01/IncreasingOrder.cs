using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona propiedades
    public int num1;
    public int num2;
    public int num3;


    // Zona de funciones
    public void Start() { IsCreasingOrder(); }

    private void IsCreasingOrder()
    {

        if(num1 < num2)
        {

            if(num2 < num3)
            {

                    Debug.Log("El orden creciente de los números es: " + num1 + " < " + num2 + " < " + num3);
            }  
        }
           

    }
    
    
        
}

 