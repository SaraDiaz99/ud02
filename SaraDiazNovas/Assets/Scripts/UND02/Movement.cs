using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Zona de propiedades
    private float _speed = 15f;
    private float _turnSpeed = 150f;
    private float _horizontal;
    private float _vertical;

    //Metodos
    void Update()
    {

        InputPlayer();
        Move();
        Turn();
    }

    //Movimiento 
    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

    }

    // Acto de Movimiento
    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    // Acto de giro
    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }
}







