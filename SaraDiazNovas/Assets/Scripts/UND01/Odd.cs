using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    //Zona de funciones
    public void Start()
    {

        IsNumberOdd();  
    
    }

    public void IsNumberOdd()
    {
        for (int i = 0; i < 101; i++)
        {

            if (i % 2 != 0)
            {

                Debug.Log(i);
            }

        }
    }
}
