using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    //Zona de funciones
    public void Start()
    {

        IsMultipleOfThreeTwo();

    }

    public void IsMultipleOfThreeTwo()
    {
        for (int i = 0; i < 101; i++)
        {

            if (i % 3 == 0)
            {

                if(i % 2 == 0)
                {
                    Debug.Log(i);

                }



            }
            
        }
    }
}
