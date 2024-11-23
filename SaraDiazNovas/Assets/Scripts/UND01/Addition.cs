using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{

    //Zona de variables
    public int num1;


    // Zona de funcion
    public void Start()
    {

        ItsAddition();

        
    }

   void ItsAddition()
    {
        int i = 0;
        int suma = 0;
        while ( i < num1+1 )
        {
            suma = suma + i;

            i++;
        }

        Debug.Log(" La suma de todos los valores hasta el " + num1 + " es " + suma );
    }
}
