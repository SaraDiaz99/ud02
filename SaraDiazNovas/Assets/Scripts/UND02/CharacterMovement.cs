using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    //Zona de variables globales
    private Animator anim;


    private void Awake()
    {

        anim = GetComponent<Animator>();

    }
   

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            Attack();

        }
        else { anim.SetBool("Attack", false); }
    }

    private void Attack()
    {

        //Ejecutar la animación
        anim.SetBool("Attack", true);
        
    }

    
}



