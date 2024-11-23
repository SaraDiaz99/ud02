using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    //Zona de funciones
    public void Start()
    {

        IsNumberEven();

    }

    public void IsNumberEven()
    {
        for (int i = 0; i < 101; i++)
        {

            if (i % 2 == 0)
            {

                Debug.Log(i);
            }

        }
    }
}
