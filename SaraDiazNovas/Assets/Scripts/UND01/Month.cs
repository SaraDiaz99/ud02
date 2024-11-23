using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Zona de Variables
    public int month;

    void Start()
    {

        GetMonthsNumbers();

    }
    //Zona de Funciones
    private void GetMonthsNumbers()
    {
        switch (month)
        {
            default:
                Debug.Log("Este numero no corresponde a ningun mes");
                break;
            case 1:
                Debug.Log("El mes 1 es Enero");
                break;
            case 2:
                Debug.Log("El mes 2 es Febrero");
                break;
            case 3:
                Debug.Log("El mes 3 es Marzo");
                break;
            case 4:
                Debug.Log("El mes 4 es Abril");
                break;
            case 5:
                Debug.Log("El mes 5 es Mayo");
                break;
            case 6:
                Debug.Log("El mes 6 es Junio");
                break;
            case 7:
                Debug.Log("El mes 7 es Julio");
                break;
            case 8:
                Debug.Log("El mes 8 es Agosto");
                break;
            case 9:
                Debug.Log("El mes 9 es Septiembre");
                break;
            case 10:
                Debug.Log("El mes 10 es Octubre");
                break;
            case 11:
                Debug.Log("El mes 11 es Noviembre");
                break;
            case 12:
                Debug.Log("El mes 12 es Diciembre");
                break;
        }
    }
}


