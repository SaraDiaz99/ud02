using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    //Zona de funciones
    public void Start()
    {

        IsMultipleOfThree();

    }

    public void IsMultipleOfThree()
    {
        for (int i = 0; i < 101; i++)
        {

            if (i % 3 == 0)
            {

                Debug.Log(i);
            }

        }
    }
}
