using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{

    // Zona de variables
    public int num1;
    public int num2;
    public int num3;

    //Zona de funciones
    void Start()
    {

        OrderNumbers();

    }

    void OrderNumbers()
    {

        int smallest, middle, largest;



        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
            if (num2 <= num3)
            {
                middle = num2;
                largest = num3;
            }
            else
            {
                middle = num3;
                largest = num2;
            }
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
            if (num1 <= num3)
            {
                middle = num1;
                largest = num3;
            }
            else
            {
                middle = num3;
                largest = num1;
            }
        }
        else
        {
            smallest = num3;
            if (num1 <= num2)
            {
                middle = num1;
                largest = num2;
            }
            else
            {
                middle = num2;
                largest = num1;
            }
        }

        Debug.Log("Este es el orden de menor a mayor:");
        Debug.Log(smallest);
        Debug.Log(middle);
        Debug.Log(largest);
    }
}


